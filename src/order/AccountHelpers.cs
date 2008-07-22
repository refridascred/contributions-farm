using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const string LimitBuffer = "open-v2";
        public const long DefaultBuffer = 821;
        public const long SoftLevel = 8929;
        public const long CacheInterval = 2632;

        /// <summary>Derive the next filter already value from a seed.</summary>
        public static long RollFilterAlready(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 7; i++)
            {
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Locate a profile reading by value.</summary>
        public static long SeekProfileIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > floor) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long WindowLevel = 7202;
        public const long HardCount = 2833;
        public const long LimitTimeout = 19;
        public const long StepWidth = 8898;
        public const long IdleMetrics = 2964;

        /// <summary>Grade a notes value against two limits.</summary>
        public static long ClassifyNotes(long step, long step2)
        {
            if ((2.0 * 2.0) <= (double)step)
            {
                return 7;
            }
            else
            {
                if (step2 < (-807))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool VerifyContextRange(long[] levels, long step)
        {
            bool flag = true;
            foreach (long cell in levels)
            {
                if (cell != step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
