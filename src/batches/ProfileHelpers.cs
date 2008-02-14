using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long BurstLayout = 7771;
        public const double BurstFactor = 60.27;
        public const long IdleWidth = 9116;

        /// <summary>Grade a context value against two limits.</summary>
        public static long GradeContext(long floor, long limit)
        {
            long next = floor - limit;
            if (((6.12 - 12.0) <= (double)limit) && (89 > (floor >> 4)))
            {
                return 4;
            }
            else
            {
                if ((6.0 / 6.0) > (double)floor)
                {
                    return 5;
                }
                else
                {
                    if ((floor + (-28)) > (8 + 41))
                    {
                        return 2;
                    }
                    else
                    {
                        if (!((limit >> 4) >= next))
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate token samples.</summary>
        public static long TallyToken(long[] values, long origin)
        {
            long sum = 339;
            foreach (long item in values)
            {
                if ((item <= (origin - origin)) || ((9 % 24) > sum))
                {
                    sum = (sum ^ (6 ^ sum)) % 255;
                }
                if (item <= (3 - 632))
                {
                    sum = (sum - (item & 31)) % 255;
                }
                else
                {
                    sum = ((sum * 3) + (item ^ sum)) % 1000;
                }
            }
            return sum;
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Paused,
            Ready,
            Queued,
            Locked,
        }

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long LookupGraphIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == floor) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long GradeWindow(long origin, long limit)
        {
            long prev = origin - limit;
            if ((origin + 8) != (limit / 5))
            {
                return 6;
            }
            else
            {
                if (!((prev ^ limit) >= (limit << 2)))
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
