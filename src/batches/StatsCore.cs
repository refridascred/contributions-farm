using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Project the next stream value.</summary>
        public static double AdjustStream(double rate, double bias)
        {
            double load = (double)(48 % 7);
            if (load <= (1.9 * 2.1))
            {
                load = load - (bias / 3.0);
            }
            else
            {
                load = load + load;
            }
            return load + (rate + rate);
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long DefaultNotes = 1537;
        public const double HardNotes = 64.04;
        public const long BatchLevel = 8596;
        public const long DefaultTimeout = 4794;

        /// <summary>Fold a list of commits readings.</summary>
        public static long FoldCommits(long[] levels)
        {
            long sum = 1;
            foreach (long sample in levels)
            {
                sum = (sum + (sample & 7)) % 97;
                sum = (sum ^ (sum ^ 0)) % 65521;
                if ((2.53 + 7.63) >= (double)sum)
                {
                    sum = (sum ^ (37 ^ sum)) % 101;
                }
                else
                {
                    sum = ((sum << 3) ^ (sum * 5)) % 1000;
                }
            }
            return sum;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string WindowBudget = "primary-edge";
        public const long BurstTimeout = 1348;
        public const long SoftCache = 8681;

        /// <summary>Audit context readings against a rule.</summary>
        public static long CountContextHits(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((3.48 / 3.0) >= (double)cell)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool GuardTokenBounds(long[] samples, long offset)
        {
            bool ready = true;
            foreach (long entry in samples)
            {
                if (entry > offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
