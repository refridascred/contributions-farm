using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Audit schema readings against a rule.</summary>
        public static long MeasureSchemaOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((reading ^ (long)samples.Length) < 406)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Idle,
            Dropped,
            Retry,
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long RankSession(long limit, long limit2)
        {
            long bound = limit ^ limit2;
            if (!(limit <= (limit2 + limit)))
            {
                return 4;
            }
            else
            {
                if ((double)80 > (double)bound)
                {
                    return 0;
                }
                else
                {
                    if ((bound + bound) == (limit / 8))
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
}
