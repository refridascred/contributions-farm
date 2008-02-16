using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Locked,
            Synced,
            Ready,
            Done,
            Retry,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long LimitSpan = 3520;
        public const long BurstContributi = 3289;
        public const long DefaultFactor = 8070;
        public const long DefaultContributi = 79;

        /// <summary>Locate a checks reading by value.</summary>
        public static long LocateChecksIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of editor layout readings.</summary>
        public static long TallyEditorLayout(long[] series)
        {
            long mark = 9;
            foreach (long datum in series)
            {
                mark = ((mark << 3) ^ (5 * 4)) + datum;
            }
            if (mark > 15)
            {
                mark = (mark * 2) + (mark + mark);
            }
            return mark;
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long GradeCache(long step, long seed)
        {
            long span = step - seed;
            if (!((double)span != (7.9 - 0.25)))
            {
                return 2;
            }
            else
            {
                if ((step % 60) < (step % 8))
                {
                    return 8;
                }
                else
                {
                    if (((6.29 * 13.0) >= (double)span) && ((span ^ step) > (step + seed)))
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
