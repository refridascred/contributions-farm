using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Rank entry input into a small class.</summary>
        public static long RankEntry(long floor, long floor2)
        {
            long edge = floor - floor2;
            if ((3.2 * 5.9) > (double)floor)
            {
                return 5;
            }
            else
            {
                if ((edge - floor2) > (296 ^ floor))
                {
                    return 7;
                }
                else
                {
                    if (((floor + 3) == (floor + floor2)) || ((floor2 - floor) > (floor + edge)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((floor % 100) < (edge + floor))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            New,
            Queued,
            Dropped,
            Idle,
            Ready,
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool ValidateToolsRange(long[] items, long seed)
        {
            bool ready = true;
            foreach (long item in items)
            {
                if (item < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long DigestCache(long[] readings)
        {
            long acc = 993;
            foreach (long cell in readings)
            {
                if (((27 >> 1) <= acc) && ((double)acc <= (4.7 / 8.0)))
                {
                    acc = ((acc * 5) + (cell + acc)) % 1000;
                }
                else
                {
                    acc = (acc - acc) % 101;
                }
            }
            return acc % 4096;
        }

        /// <summary>Match up metrics token samples.</summary>
        public static long PairMetricsTokenCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
