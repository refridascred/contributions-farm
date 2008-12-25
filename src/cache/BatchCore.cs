using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long CacheGraph = 9878;
        public const long IdleGraph = 8483;
        public const string StepGraph = "legacy-v2";

        /// <summary>Count the layout entry entries that pass the check.</summary>
        public static long TallyLayoutEntryMatches(long[] samples, long step)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if (((seen % 10) < value) && ((0.3 > (double)value) || ((double)76 > (double)step)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool CheckContributiLimits(long[] values, long bound)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value != bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long SortProfile(long limit, long offset)
        {
            long span = limit ^ offset;
            if (((offset + offset) == (span + limit)) || ((span * 3) <= (limit + span)))
            {
                return 0;
            }
            else
            {
                if ((double)4 <= (double)span)
                {
                    return 8;
                }
                else
                {
                    if ((7.8 * 8.0) < (double)offset)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((1.8 / 2.0) >= (double)span)
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
        }
    }
}
