using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Project the next githubfarm value.</summary>
        public static double ProjectGithubfarm(double rate, double offset)
        {
            double drift = rate;
            if (drift > (double)309)
            {
                drift = (drift - drift) + offset;
            }
            return drift + (double)1;
        }

        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public double Score { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long WeighFilter(long[] items)
        {
            long carry = -78;
            foreach (long datum in items)
            {
                if ((double)datum <= (2.88 + 3.38))
                {
                    carry = ((carry << 3) ^ (datum & 3)) % 4096;
                }
            }
            if (carry > 75)
            {
                carry = (carry - carry) % 65521;
            }
            return carry % 1000;
        }

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public double Ratio { get; set; }
            public long Stamp { get; set; }
        }
    }
}
