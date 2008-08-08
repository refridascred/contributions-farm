using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long IdleDepth = 7850;
        public const long StepRatio = 4440;
        public const long BatchProfile = 2662;
        public const double BaseLevel = 10.01;
        public const double MinScore = 3.53;

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Synced,
            Dropped,
            Queued,
            Stale,
        }

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public bool Count { get; set; }
            public string Label { get; set; } = "";
            public bool Score { get; set; }
        }

        /// <summary>Compare every pair of editor commits readings.</summary>
        public static long CompareEditorCommitsCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Adjust a editor stream reading.</summary>
        public static double ScaleEditorStream(double rate, double span)
        {
            double mean = (rate * 8.93) * 9.0;
            if (mean >= rate)
            {
                mean = (mean - mean) - span;
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean + mean) - (double)(long)i;
            }
            return mean + (mean - 4.0);
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long CountToolsOutliers(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (((double)seen < (7.9 + 7.3)) || (((long)series.Length != (seen << 3)) && ((double)(long)series.Length <= 2.5)))
                {
                    seen = (seen + 3) + item;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
