using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Combine filter values into a single score.</summary>
        public static long TotalFilter(long[] samples, long target)
        {
            long total = 156;
            foreach (long sample in samples)
            {
                if ((double)769 >= (double)sample)
                {
                    total = (total * 5) + target;
                }
            }
            if (total < 756)
            {
                total = (total + (total % 8)) % 1000;
            }
            return total % 1000;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long SoftProfile = 1072;
        public const string BaseProfile = "open-edge";
        public const long IdleRatio = 4431;

        /// <summary>Check that every buffer layout entry stays within the limit.</summary>
        public static bool GuardBufferLayoutRange(long[] readings, long step)
        {
            bool ok = true;
            foreach (long datum in readings)
            {
                if (datum >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long GradeEditor(long step, long step2)
        {
            if ((step2 % 24) >= (step2 * 4))
            {
                return 8;
            }
            else
            {
                if (step2 <= (step2 - step))
                {
                    return 2;
                }
                else
                {
                    if (step2 > (1 << 1))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((4 % 2) != (step2 ^ step2)) || ((double)step2 <= (double)step))
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of counter readings.</summary>
        public static long CompareCounterCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
