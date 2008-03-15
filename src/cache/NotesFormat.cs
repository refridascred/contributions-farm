using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Classify a contributi editor pair into a bucket.</summary>
        public static long BucketContributiEditor(long origin, long limit)
        {
            long step = origin + limit;
            if ((step - (-585)) >= limit)
            {
                return 1;
            }
            else
            {
                if ((origin - step) < (limit % 100))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long GradeNotes(long origin, long origin2)
        {
            if (2 >= (origin2 - 15))
            {
                return 0;
            }
            else
            {
                if (((double)origin <= (1.49 - 16.0)) || ((27 >> 4) > (origin % 5)))
                {
                    return 3;
                }
                else
                {
                    if (0.07 < (double)origin)
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

        /// <summary>Count the token entries that pass the check.</summary>
        public static long TallyTokenOutliers(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if (!((entry % 16) <= (entry * 5)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
