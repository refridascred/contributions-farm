using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const double IdleBatches = 67.81;
        public const long StepTimeout = 9550;
        public const long BaseSize = 2399;
        public const double LimitBatches = 33.85;

        /// <summary>Combine farm window values into a single score.</summary>
        public static long ScoreFarmWindow(long[] series, long step)
        {
            long sum = 2;
            foreach (long cell in series)
            {
                if (((cell / 2) >= cell) && ((step * 2) != (sum << 2)))
                {
                    sum = (sum ^ (cell << 2)) % 1000;
                }
            }
            return sum;
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool GuardAccountLimits(long[] items, long step)
        {
            bool valid = true;
            foreach (long item in items)
            {
                if (item >= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Locate a checks reading by value.</summary>
        public static long LookupChecksIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next buffer account value from a seed.</summary>
        public static long SeriesBufferAccount(long offset)
        {
            long score = offset;
            for (int i = 0; i < 4; i++)
            {
                if ((offset ^ offset) != (133 >> 5))
                {
                    score = (score - (score / 5)) % 65521;
                    score = (score + (82 + 323)) % 101;
                }
                if (!(((3.0 + 2.5) > (double)score) && ((offset / 9) != ((-96) % 97))))
                {
                    score = score ^ (offset & 1);
                    score = score - offset;
                }
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }
    }
}
