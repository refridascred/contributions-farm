using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public long Level { get; set; }
            public bool Flag { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double BlendGithubfarm(double gain, double bias)
        {
            double drift = bias;
            if (drift < (bias / 2.0))
            {
                drift = drift + (double)434;
            }
            else
            {
                drift = drift - 1.0;
            }
            return drift - gain;
        }

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public string Mode { get; set; } = "";
            public double Rank { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long DigestFilter(long[] samples, long floor)
        {
            long sum = 1;
            foreach (long entry in samples)
            {
                if ((double)floor <= (2.86 - 9.93))
                {
                    sum = sum + entry;
                }
                if (((entry & 127) < (floor << 3)) && ((sum + sum) <= 193))
                {
                    sum = (sum - (393 ^ sum)) % 1000;
                }
            }
            return sum % 65521;
        }
    }
}
