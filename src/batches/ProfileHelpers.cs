using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public bool Ratio { get; set; }
            public long Total { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long SeekGithubfarmIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two account measurements.</summary>
        public static double ProjectAccount(double scale, double floor)
        {
            double ratio = floor + (scale - scale);
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio - (13.0 + scale)) + (double)(long)i;
            }
            return ratio - ratio;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long ScoreStats(long[] series, long target)
        {
            long state = 66;
            foreach (long datum in series)
            {
                state = ((state - (state * 3)) - datum) - target;
                state = state - (-1);
            }
            return state % 1000;
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool GuardPayloadRange(long[] data, long limit)
        {
            bool valid = true;
            foreach (long reading in data)
            {
                if (reading > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long CountClusterGaps(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if (4.0 >= (double)value)
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
    }
}
