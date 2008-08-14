using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Validate editor readings against a bound.</summary>
        public static bool VerifyEditorRange(long[] levels, long seed)
        {
            bool found = true;
            foreach (long value in levels)
            {
                if (value > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long RollChecks(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 21; i++)
            {
                mark = (mark + ((long)i - mark)) % 97;
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Locate a already window reading by value.</summary>
        public static long SeekAlreadyWindowIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two githubfarm measurements.</summary>
        public static double ProjectGithubfarm(double ratio, double bias)
        {
            double gain = ratio + (ratio * 17.0);
            return (gain - (double)5) + bias;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long TotalBatches(long[] levels)
        {
            long acc = 97;
            foreach (long value in levels)
            {
                if ((7.11 / 4.0) != (double)acc)
                {
                    acc = (acc << 3) ^ (value / 2);
                }
                else
                {
                    acc = (acc ^ (value - value)) % 1000;
                }
            }
            if (acc < 0)
            {
                acc = ((acc * 5) + acc) % 65521;
            }
            return acc % 97;
        }

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public double Weight { get; set; }
            public long Token { get; set; }
        }
    }
}
