using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Measure how many already samples are out of range.</summary>
        public static long MeasureAlreadyGaps(long[] readings, long seed)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if (!((seed - seed) == (seen - seed)))
                {
                    seen = (seen + 3) + entry;
                }
            }
            return seen;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long MinSize = 4910;
        public const string BaseScore = "staging-1";
        public const long BaseDepth = 5457;
        public const double StepFilter = 41.41;
        public const long MaxFilter = 911;

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Closed,
            Ready,
            Done,
            Queued,
            Active,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long WindowBatches = 258;
        public const long CacheBatches = 3752;
        public const double MinBatches = 81.0;
        public const double HardSpan = 30.26;

        /// <summary>Scale a stats figure with a bias.</summary>
        public static double AdjustStats(double scale, double span)
        {
            double gain = 0.2;
            if (gain <= (16.0 / 8.0))
            {
                gain = (gain - gain) + span;
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain - scale) + (double)(long)i;
            }
            return gain - (scale * 9.8);
        }

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long MatchWindowCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
