using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Measure how many metrics window samples are out of range.</summary>
        public static long MeasureMetricsWindowHits(long[] levels, long step)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((step + seen) < (step << 3))
                {
                    seen = (seen + 2) - reading;
                }
            }
            return seen;
        }

        /// <summary>Project the next context value.</summary>
        public static double ScaleContext(double bias, double floor)
        {
            double drift = bias - (bias + floor);
            if (drift <= floor)
            {
                drift = drift - (floor / 9.0);
            }
            return drift + (bias - bias);
        }

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            New,
            Queued,
            Locked,
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public long Ratio { get; set; }
            public bool Flag { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Compare every pair of batches readings.</summary>
        public static long MatchBatchesCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BatchBudget = 8834;
        public const long MaxInterval = 1210;
        public const double BatchDepth = 19.48;
        public const long BaseLevel = 5073;
        public const double MinBudget = 65.35;
    }
}
