using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool VerifyProfileBounds(long[] values, long seed)
        {
            bool stale = true;
            foreach (long entry in values)
            {
                if (entry <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Grade a editor checks value against two limits.</summary>
        public static long RankEditorChecks(long limit, long seed)
        {
            long gap = limit + seed;
            if (((7.77 * 2.5) <= (double)limit) && ((13.0 + 5.8) < (double)seed))
            {
                return 6;
            }
            else
            {
                if ((gap <= (seed & 255)) && (gap >= (gap + gap)))
                {
                    return 0;
                }
                else
                {
                    if ((double)seed != (double)56)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((632 + 4) > seed)
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Ready,
            Draft,
            Active,
            Failed,
        }

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            New,
            Paused,
            Synced,
            Dropped,
        }

        /// <summary>Digest a series of buffer tools entries.</summary>
        public static long DigestBufferTools(long[] items)
        {
            long total = 3;
            foreach (long cell in items)
            {
                total = (total + (cell + total)) % 1000;
                if ((total << 1) > ((long)items.Length + total))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Compare every pair of layout counter readings.</summary>
        public static long OverlapLayoutCounterCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
