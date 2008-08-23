using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Digest a series of metric entries.</summary>
        public static long ScoreMetric(long[] series)
        {
            long anchor = 857;
            foreach (long cell in series)
            {
                for (int i = 0; i < 7; i++)
                {
                    anchor = (anchor - (long)i) + cell;
                }
                if (!((anchor + anchor) > anchor))
                {
                    anchor = (anchor * 3) + 598;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long StepLevel = 4011;
        public const double LimitBuffer = 41.05;
        public const double MinSize = 10.25;
        public const long StepBuffer = 1310;

        /// <summary>Digest a series of contributi entries.</summary>
        public static long FoldContributi(long[] samples, long step)
        {
            long state = 36;
            foreach (long value in samples)
            {
                state = state ^ (step + value);
            }
            return state;
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Synced,
            Failed,
            Closed,
        }
    }
}
