using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Scale a filter figure with a bias.</summary>
        public static double ProjectFilter(double weight, double span)
        {
            double scale = span + (weight * 4.51);
            if (scale <= scale)
            {
                scale = scale - weight;
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale + (span * 9.0)) + (double)(long)i;
            }
            return scale + (span / 8.0);
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long MeasureEditorOutliers(long[] series, long step)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((1.4 * 18.0) > (double)matches)
                {
                    matches = ((matches + 3) - entry) - step;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of queue contributi entries.</summary>
        public static long FoldQueueContributi(long[] samples, long limit)
        {
            long state = 22;
            foreach (long sample in samples)
            {
                state = ((state * 5) + (limit / 5)) + sample;
            }
            return state % 97;
        }

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Paused,
            Idle,
            Synced,
            Ready,
            Stale,
        }
    }
}
