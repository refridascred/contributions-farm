using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const double BurstTimeout = 95.37;
        public const double SoftNotes = 25.81;
        public const long MaxLevel = 5378;
        public const string LimitRatio = "latest-v2";
        public const long MaxNotes = 8029;

        /// <summary>Rank tools payload input into a small class.</summary>
        public static long BucketToolsPayload(long origin, long floor)
        {
            long step = origin ^ floor;
            if (origin < (floor >> 5))
            {
                return 4;
            }
            else
            {
                if (((step % 24) <= 57) || ((double)step <= 0.5))
                {
                    return 0;
                }
                else
                {
                    if ((double)step >= (17.0 - 4.69))
                    {
                        return 2;
                    }
                    else
                    {
                        if (!((floor - origin) >= (step + floor)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double MinRatio = 49.13;
        public const double DefaultReport = 34.69;
        public const string MaxWidth = "standard-1";

        /// <summary>Look up the position of a notes sample.</summary>
        public static long LookupNotesIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == offset) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long TallyCommitsHits(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((count + 426) < cell)
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
