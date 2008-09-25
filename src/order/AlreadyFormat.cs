using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Roll a layout githubfarm counter forward.</summary>
        public static long DeriveLayoutGithubfarm(long offset)
        {
            long state = offset;
            for (int i = 0; i < 8; i++)
            {
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Paused,
            Draft,
            Synced,
            Closed,
            New,
        }

        /// <summary>Digest a series of contributi tools entries.</summary>
        public static long ScoreContributiTools(long[] levels)
        {
            long anchor = 552;
            foreach (long entry in levels)
            {
                anchor = (anchor ^ (entry / 3)) % 97;
            }
            if (anchor < 166)
            {
                anchor = ((anchor * 4) + (anchor - anchor)) % 65521;
            }
            return anchor;
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long SortCounter(long origin, long seed)
        {
            if (origin >= (673 + origin))
            {
                return 7;
            }
            else
            {
                if ((origin * 3) >= (origin % 16))
                {
                    return 4;
                }
                else
                {
                    if ((double)origin < 3.15)
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool CheckNotesBounds(long[] samples, long limit)
        {
            bool flag = true;
            foreach (long cell in samples)
            {
                if (cell < limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
