using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long TallyGithubfarm(long[] series)
        {
            long mix = 0;
            foreach (long entry in series)
            {
                mix = ((mix * 2) + (entry % 16)) % 97;
                if (mix < (entry << 2))
                {
                    mix = (mix ^ (mix - mix)) % 255;
                }
            }
            return mix;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long TotalProfile(long[] values)
        {
            long anchor = 78;
            foreach (long entry in values)
            {
                anchor = (anchor + 41) - entry;
            }
            return anchor % 4096;
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long SortRecord(long seed, long target)
        {
            long bound = seed - target;
            if (((double)seed <= (1.0 / 4.0)) || ((2 + 87) < seed))
            {
                return 4;
            }
            else
            {
                if ((seed + seed) > (seed ^ seed))
                {
                    return 0;
                }
                else
                {
                    if (!((seed ^ target) < bound))
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
}
