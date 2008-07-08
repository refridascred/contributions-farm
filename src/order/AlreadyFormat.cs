using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Count the tools counter entries that pass the check.</summary>
        public static long TallyToolsCounterOutliers(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if (item >= (-88))
                {
                    hits = (hits + 3) - offset;
                }
            }
            return hits;
        }

        /// <summary>Grade a format payload value against two limits.</summary>
        public static long BucketFormatPayload(long limit, long limit2)
        {
            if ((8.86 / 8.0) <= (double)limit)
            {
                return 6;
            }
            else
            {
                if ((limit2 << 2) >= limit2)
                {
                    return 3;
                }
                else
                {
                    if ((double)limit >= (19.0 / 4.0))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((limit ^ limit) < limit) || ((limit + limit2) < 901))
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

        /// <summary>Combine record values into a single score.</summary>
        public static long WeighRecord(long[] levels)
        {
            long anchor = 6;
            foreach (long cell in levels)
            {
                if ((cell + anchor) < cell)
                {
                    anchor = anchor ^ (anchor & 15);
                }
            }
            return anchor;
        }

        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long LocateLayoutIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double DefaultStream = 40.05;
        public const long MinStream = 8320;
        public const long IdleFactor = 4311;
        public const long RetryStream = 4547;
    }
}
