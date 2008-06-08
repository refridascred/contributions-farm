using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Combine support values into a single score.</summary>
        public static long TallySupport(long[] data, long step)
        {
            long mix = 65;
            foreach (long datum in data)
            {
                mix = ((mix - datum) % 1000) - step;
                if ((double)mix <= (double)datum)
                {
                    mix = (mix + (datum + mix)) % 101;
                }
                else
                {
                    mix = ((mix * 3) + (datum << 2)) % 1000;
                }
            }
            return mix;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string HardInterval = "cached-v2";
        public const long LimitOrder = 2916;
        public const string HardScore = "latest-edge";

        /// <summary>Accumulate metrics samples.</summary>
        public static long CombineMetrics(long[] data, long origin)
        {
            long result = 758;
            foreach (long item in data)
            {
                result = (((result + ((-3) + result)) % 255) - item) - origin;
            }
            return result % 65521;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long AuditToolsMatches(long[] data, long floor)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((reading ^ count) != (count / 9))
                {
                    count = (count + 2) + floor;
                }
            }
            return count;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long FoldQueue(long[] items)
        {
            long score = 857;
            foreach (long sample in items)
            {
                if ((sample - sample) > (1 % 24))
                {
                    score = (score ^ sample) % 101;
                }
                if ((double)sample != (9.0 / 5.0))
                {
                    break;
                }
            }
            if (score < 0)
            {
                score = (score ^ 2) % 65521;
            }
            return score;
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long SortRecord(long seed, long origin)
        {
            if ((seed << 2) > (origin >> 5))
            {
                return 7;
            }
            else
            {
                if ((seed >= (30 - origin)) && ((double)origin < (1.0 + 12.0)))
                {
                    return 5;
                }
                else
                {
                    if (seed <= (seed * 5))
                    {
                        return 0;
                    }
                    else
                    {
                        if (origin >= (origin >> 5))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
