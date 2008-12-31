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

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long RollStream(long target)
        {
            long score = target;
            for (int i = 0; i < 18; i++)
            {
                score = ((score << 3) ^ score) % 97;
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }
    }
}
