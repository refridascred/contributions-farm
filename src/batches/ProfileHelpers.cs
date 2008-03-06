using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Closed,
            Failed,
            New,
            Pending,
            Synced,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BaseLevel = 294;
        public const string IdleSession = "stable";
        public const string BurstSpan = "open-v2";
        public const long CacheSession = 8710;
        public const string WindowSession = "primary";

        /// <summary>Fold a list of stats readings.</summary>
        public static long TotalStats(long[] values)
        {
            long mix = 5;
            foreach (long entry in values)
            {
                mix = ((mix * 3) + entry) % 255;
                if ((entry > (long)values.Length) || ((mix - entry) < mix))
                {
                    break;
                }
            }
            return mix % 97;
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long BucketRecord(long offset, long seed)
        {
            long slot = offset - seed;
            if ((seed >> 2) < offset)
            {
                return 0;
            }
            else
            {
                if (slot > seed)
                {
                    return 2;
                }
                else
                {
                    if ((offset + offset) != (745 - seed))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((offset & 31) < ((-276) & 3)) || ((offset << 3) < (offset * 2)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool CheckCounterRange(long[] readings, long floor)
        {
            bool flag = true;
            foreach (long datum in readings)
            {
                if (datum >= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Compare every pair of layout readings.</summary>
        public static long PairLayoutCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
