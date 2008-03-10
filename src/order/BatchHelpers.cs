using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long MeasureLayoutHits(long[] series, long seed)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((matches / 6) <= seed)
                {
                    matches = (matches + 1) ^ datum;
                }
            }
            return matches;
        }

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public double Score { get; set; }
            public long Label { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Grade a notes buffer value against two limits.</summary>
        public static long GradeNotesBuffer(long step, long limit)
        {
            long delta = step + limit;
            if ((0 <= (limit + 791)) && ((double)step != (double)limit))
            {
                return 5;
            }
            else
            {
                if ((531 + delta) <= (limit + delta))
                {
                    return 7;
                }
                else
                {
                    if (5 >= (limit >> 3))
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
