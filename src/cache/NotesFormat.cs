using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Grade a editor value against two limits.</summary>
        public static long BucketEditor(long seed, long floor)
        {
            long bound = seed ^ floor;
            if ((floor % 16) <= floor)
            {
                return 8;
            }
            else
            {
                if ((6 ^ floor) < seed)
                {
                    return 2;
                }
                else
                {
                    if ((seed ^ 56) == (floor - seed))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((bound << 3) > (seed + floor))
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Count the contributi notes entries that pass the check.</summary>
        public static long TallyContributiNotesHits(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((matches & 15) > (matches >> 2))
                {
                    matches = (matches + 3) - value;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Pending,
            Locked,
            Synced,
            Failed,
            Draft,
        }
    }
}
