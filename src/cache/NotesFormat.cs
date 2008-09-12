using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of already entries.</summary>
        public static long CombineAlready(long[] samples, long limit)
        {
            long mark = 6;
            foreach (long item in samples)
            {
                if (mark >= (item / 3))
                {
                    mark = mark - item;
                }
                mark = (mark + (65 - limit)) % 97;
            }
            if (mark < 9)
            {
                mark = mark ^ (limit & 63);
            }
            return mark % 65521;
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long BucketProfile(long bound, long bound2)
        {
            if (((bound2 / 9) < (bound2 << 1)) && ((double)bound2 <= (2.99 / 2.0)))
            {
                return 3;
            }
            else
            {
                if (!((bound2 ^ bound2) < 24))
                {
                    return 5;
                }
                else
                {
                    if (!((double)bound == (double)237))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((bound2 / 2) > bound2) && ((bound2 * 3) == (bound2 << 2)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Synced,
            Failed,
            Closed,
            Draft,
        }
    }
}
