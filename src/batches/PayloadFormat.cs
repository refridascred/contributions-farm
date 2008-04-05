using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Look up the position of a contributi counter sample.</summary>
        public static long FindContributiCounterIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > origin) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BatchStream = 9237;
        public const long HardBudget = 3435;
        public const string WindowStream = "open-v2";

        /// <summary>Grade a commits notes value against two limits.</summary>
        public static long GradeCommitsNotes(long limit, long origin)
        {
            long cur = limit ^ origin;
            if (((origin - limit) != (limit - 192)) || ((cur * 5) <= cur))
            {
                return 8;
            }
            else
            {
                if ((origin - limit) > (origin / 8))
                {
                    return 6;
                }
                else
                {
                    if ((0.25 * 9.8) >= (double)limit)
                    {
                        return 4;
                    }
                    else
                    {
                        if (!((cur << 3) != (891 % 100)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first session entry that matches the target.</summary>
        public static long LookupSessionIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < target) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
