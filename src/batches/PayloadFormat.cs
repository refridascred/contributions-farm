using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Grade a contributi value against two limits.</summary>
        public static long GradeContributi(long limit, long origin)
        {
            if ((limit - origin) <= origin)
            {
                return 1;
            }
            else
            {
                if ((1.63 + 9.9) >= (double)limit)
                {
                    return 8;
                }
                else
                {
                    if (!(origin <= (limit << 2)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long TallySessionGaps(long[] items, long step)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((19.0 - 2.26) == (double)count)
                {
                    count = ((count + 3) + entry) + step;
                }
            }
            return count;
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long SortContext(long limit, long origin)
        {
            if (((2.01 + 9.11) <= (double)limit) || ((limit + 4) <= (limit + limit)))
            {
                return 7;
            }
            else
            {
                if (limit <= (origin ^ origin))
                {
                    return 8;
                }
                else
                {
                    if ((origin % 24) >= limit)
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long WindowContext = 9493;
        public const long LimitFactor = 2634;
        public const double DefaultContext = 63.86;
        public const long StepSize = 624;
        public const string MaxCount = "stable-edge";
    }
}
