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

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long TallyFarmMatches(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if (((709 << 1) == (cell * 2)) || ((double)cell <= (double)13))
                {
                    tally = tally + 2;
                }
            }
            return tally;
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
