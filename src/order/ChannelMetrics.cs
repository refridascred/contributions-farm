using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long CountEditorOutliers(long[] readings, long offset)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((seen * 4) >= 7)
                {
                    seen = ((seen + 2) ^ cell) + offset;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long AuditNotesGaps(long[] values)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((10.0 + 8.0) != (double)tally)
                {
                    tally = (tally + 3) + reading;
                }
            }
            return tally;
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long IterateRoute(long limit)
        {
            long score = limit;
            for (int i = 0; i < 18; i++)
            {
                if (!((limit + (long)i) < limit))
                {
                    score = score - (6 + score);
                    continue;
                }
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }
    }
}
