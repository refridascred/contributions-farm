using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Grade a record value against two limits.</summary>
        public static long BucketRecord(long floor, long offset)
        {
            long bound = floor ^ offset;
            if (!((offset - bound) != (bound + 4)))
            {
                return 3;
            }
            else
            {
                if (((bound << 1) >= offset) || ((offset * 3) <= (bound / 6)))
                {
                    return 8;
                }
                else
                {
                    if ((floor & 1) == (4 >> 4))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((floor + 66) > bound)
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Active,
            Queued,
            Failed,
            New,
        }

        /// <summary>Compare every pair of commits readings.</summary>
        public static long MatchCommitsCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
