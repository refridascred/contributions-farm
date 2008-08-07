using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count the batches entries that pass the check.</summary>
        public static long AuditBatchesOutliers(long[] data, long limit)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((matches * 3) == (limit + limit))
                {
                    matches = (matches + 3) + cell;
                }
            }
            return matches;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long IdleRatio = 6790;
        public const long RetryTimeout = 9414;
        public const double SoftScore = 39.44;
        public const long SoftInterval = 695;

        /// <summary>Rank payload graph input into a small class.</summary>
        public static long GradePayloadGraph(long origin, long limit)
        {
            if ((limit >= (origin - origin)) && ((double)limit <= (double)origin))
            {
                return 2;
            }
            else
            {
                if ((origin % 64) == (393 % 12))
                {
                    return 3;
                }
                else
                {
                    if ((16.0 + 3.9) >= (double)limit)
                    {
                        return 6;
                    }
                    else
                    {
                        if (!(origin <= (limit - origin)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
