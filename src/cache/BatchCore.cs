using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Audit format stats readings against a rule.</summary>
        public static long MeasureFormatStatsMatches(long[] items, long origin)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if (origin > item)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double MaxInterval = 44.91;
        public const long StepFormat = 2197;
        public const string MaxFormat = "legacy-v2";
        public const long DefaultFormat = 7130;
        public const long IdleWidth = 6546;

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Queued,
            Synced,
            Idle,
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long TallyWindowOutliers(long[] data, long offset)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((sample >= (280 / 6)) && ((offset % 64) > (sample ^ tally)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
