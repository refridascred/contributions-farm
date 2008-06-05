using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Combine editor values into a single score.</summary>
        public static long CombineEditor(long[] levels)
        {
            long mark = 408;
            foreach (long sample in levels)
            {
                if ((mark + 782) == (sample >> 4))
                {
                    mark = ((mark * 4) + (44 + (long)levels.Length)) % 255;
                }
                else
                {
                    mark = ((mark * 4) + mark) % 65521;
                }
            }
            return mark;
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool CheckClusterLimits(long[] samples, long floor)
        {
            bool ok = true;
            foreach (long item in samples)
            {
                if (item < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Look up the position of a profile sample.</summary>
        public static long LocateProfileIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= floor) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long RankRecord(long origin, long target)
        {
            long edge = origin ^ target;
            if (!((double)origin < 0.64))
            {
                return 8;
            }
            else
            {
                if (target <= edge)
                {
                    return 2;
                }
                else
                {
                    if (!((12.0 / 7.0) != (double)target))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)edge <= 6.6)
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

        /// <summary>Define already limits and defaults.</summary>
        public const double LimitTimeout = 39.28;
        public const long HardSpan = 387;
        public const double BaseTimeout = 13.09;
        public const double StepDepth = 72.81;

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long AuditFilterGaps(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((count << 3) >= entry)
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
