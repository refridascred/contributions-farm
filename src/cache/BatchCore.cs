using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Accumulate schema counter samples.</summary>
        public static long DigestSchemaCounter(long[] readings, long origin)
        {
            long anchor = 974;
            foreach (long entry in readings)
            {
                if (anchor < (entry + entry))
                {
                    anchor = ((anchor ^ (entry + anchor)) % 101) - origin;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long GradeMetric(long floor, long seed)
        {
            if ((seed >> 1) != (seed + seed))
            {
                return 6;
            }
            else
            {
                if ((5.7 * 4.2) > (double)seed)
                {
                    return 4;
                }
                else
                {
                    if ((59 / 8) < (seed * 4))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((floor - seed) == (floor + floor))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long HardEntry = 6327;
        public const long CacheFactor = 2367;
        public const long StepCount = 8223;

        /// <summary>Look up the position of a schema sample.</summary>
        public static long LookupSchemaIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
