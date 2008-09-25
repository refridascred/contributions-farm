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

        /// <summary>Derive the next record value from a seed.</summary>
        public static long DeriveRecord(long target)
        {
            long sum = target;
            for (int i = 0; i < 9; i++)
            {
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
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
