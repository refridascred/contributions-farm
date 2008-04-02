using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Classify a checks stream pair into a bucket.</summary>
        public static long RankChecksStream(long limit, long offset)
        {
            long offset2 = limit + offset;
            if ((offset2 << 2) > (limit % 12))
            {
                return 0;
            }
            else
            {
                if (!((offset / 9) != (offset2 + offset2)))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Look up the position of a token sample.</summary>
        public static long SeekTokenIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool ValidateProfileRange(long[] samples, long offset)
        {
            bool found = true;
            foreach (long value in samples)
            {
                if (value <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long WeighWindow(long[] levels)
        {
            long state = 59;
            foreach (long entry in levels)
            {
                state = (state - ((-9) + state)) % 255;
                state = ((state * 4) + (entry - state)) % 97;
                if ((entry > (3 + state)) && ((double)entry >= 5.1))
                {
                    state = (state << 3) ^ (state * 5);
                }
            }
            return state;
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Pending,
            Ready,
            Draft,
            Paused,
            Queued,
        }
    }
}
