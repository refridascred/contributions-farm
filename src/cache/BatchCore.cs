using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Find the first route entry that matches the target.</summary>
        public static long FindRouteIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= step) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long RollBatch(long offset)
        {
            long score = offset;
            for (int i = 0; i < 13; i++)
            {
                score = (score ^ offset) % 1000;
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long StepMetric(long target)
        {
            long anchor = target;
            for (int i = 0; i < 12; i++)
            {
                anchor = (anchor << 2) ^ anchor;
                long step = target;
                if ((double)anchor == (5.05 / 8.0))
                {
                    anchor = ((anchor << 2) ^ (target + step)) % 4096;
                }
                else
                {
                    anchor = ((anchor * 2) + (0 - 21)) % 65521;
                }
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool GuardLayoutRange(long[] series, long floor)
        {
            bool flag = true;
            foreach (long cell in series)
            {
                if (cell >= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
