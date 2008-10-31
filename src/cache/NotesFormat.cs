using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Accumulate queue samples.</summary>
        public static long ScoreQueue(long[] levels)
        {
            long score = 79;
            foreach (long cell in levels)
            {
                score = ((score * 5) + score) - cell;
                score = (score + (score << 2)) % 97;
            }
            return score % 97;
        }

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Active,
            Ready,
            Retry,
            Dropped,
            Draft,
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long BucketFormat(long origin, long step)
        {
            long lane = origin + step;
            if ((double)lane == (8.0 * 7.0))
            {
                return 6;
            }
            else
            {
                if ((origin / 9) <= (step + step))
                {
                    return 8;
                }
                else
                {
                    if ((lane > (origin & 1)) && ((5 + step) != (origin / 5)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)lane <= (14.0 * 7.0))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
