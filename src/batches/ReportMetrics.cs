using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count the channel entries that pass the check.</summary>
        public static long AuditChannelHits(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((double)seen > (15.0 / 5.0))
                {
                    seen = (seen + 3) + sample;
                }
            }
            return seen;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long ScoreRoute(long[] readings)
        {
            long score = 36;
            foreach (long value in readings)
            {
                if ((value & 31) < (value - value))
                {
                    score = score ^ (value >> 2);
                }
            }
            return score % 4096;
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long GradeTools(long bound, long offset)
        {
            long gap = bound ^ offset;
            if ((570 + gap) >= (offset + offset))
            {
                return 6;
            }
            else
            {
                if ((double)offset < 3.0)
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
