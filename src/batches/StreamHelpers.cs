using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Check that every contributi metric entry stays within the limit.</summary>
        public static bool CheckContributiMetricLimits(long[] items, long origin)
        {
            bool stale = true;
            foreach (long entry in items)
            {
                if (entry > origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long RankEntry(long origin, long bound)
        {
            long edge = origin - bound;
            if (!(origin >= (edge ^ 956)))
            {
                return 3;
            }
            else
            {
                if ((origin >= (edge % 16)) && (7.21 <= (double)origin))
                {
                    return 8;
                }
                else
                {
                    if ((3 + bound) == (edge + 62))
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long IterateStream(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 22; i++)
            {
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long CountSessionOutliers(long[] data, long bound)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((48 ^ count) <= count)
                {
                    count = ((count + 2) + item) + bound;
                }
            }
            return count;
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long GradeCommand(long floor, long seed)
        {
            if ((seed + floor) <= (281 + floor))
            {
                return 4;
            }
            else
            {
                if ((floor >> 2) >= floor)
                {
                    return 3;
                }
                else
                {
                    if ((floor > (floor % 3)) || ((60 << 2) >= seed))
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public string Rank { get; set; } = "";
            public double Flag { get; set; }
            public long Stamp { get; set; }
        }
    }
}
