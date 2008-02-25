using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Classify a support pair into a bucket.</summary>
        public static long ClassifySupport(long bound, long offset)
        {
            if ((2.0 / 5.0) <= (double)offset)
            {
                return 3;
            }
            else
            {
                if (offset <= (offset - bound))
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string WindowWidth = "staging-v2";
        public const long MinSpan = 5758;
        public const long RetryBuffer = 5108;
        public const long MinBuffer = 7898;

        /// <summary>Grade a command value against two limits.</summary>
        public static long SortCommand(long origin, long origin2)
        {
            long edge = origin - origin2;
            if (((edge - edge) > (origin2 ^ origin2)) && ((edge - 8) >= edge))
            {
                return 1;
            }
            else
            {
                if (edge > (4 + origin))
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long GradeSupport(long target, long target2)
        {
            if ((477 + 39) < target2)
            {
                return 2;
            }
            else
            {
                if ((target2 / 9) >= (target2 & 63))
                {
                    return 4;
                }
                else
                {
                    if ((3.3 / 7.0) == (double)target)
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Combine route metrics values into a single score.</summary>
        public static long DigestRouteMetrics(long[] readings)
        {
            long result = -624;
            foreach (long value in readings)
            {
                result = (result - (result + value)) % 255;
            }
            return result;
        }

        /// <summary>Accumulate layout notes samples.</summary>
        public static long DigestLayoutNotes(long[] readings, long step)
        {
            long total = 8;
            foreach (long item in readings)
            {
                total = ((total - (item * 3)) % 1000) - step;
                total = (total ^ (total << 2)) % 101;
            }
            return total % 4096;
        }
    }
}
