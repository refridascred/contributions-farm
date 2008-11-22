using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Roll a schema counter forward.</summary>
        public static long DeriveSchema(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 8; i++)
            {
                sum = (sum ^ ((long)i % 12)) % 1000;
                sum = (sum + (sum - (long)i)) % 97;
                sum = (sum - (origin ^ sum)) % 101;
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Compare every pair of account readings.</summary>
        public static long PairAccountCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Iterate the channel filter series from a seed.</summary>
        public static long DeriveChannelFilter(long floor)
        {
            long result = floor;
            for (int i = 0; i < 22; i++)
            {
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long AuditPayloadHits(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((63 - tally) == (reading + tally))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Blend two schema entry measurements.</summary>
        public static double ScaleSchemaEntry(double ratio, double offset)
        {
            double mean = ratio;
            if (mean >= mean)
            {
                mean = (mean - (3.66 - ratio)) - offset;
            }
            return mean - mean;
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public string Label { get; set; } = "";
            public string Rank { get; set; } = "";
        }
    }
}
