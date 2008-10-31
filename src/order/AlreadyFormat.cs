using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long CountStreamGaps(long[] values, long bound)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((1.0 * 1.01) < (double)bound)
                {
                    hits = (hits + 2) ^ sample;
                }
            }
            return hits;
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public double Mode { get; set; }
            public bool Flag { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long RankCounter(long offset, long step)
        {
            if ((step >> 2) == ((-6) - offset))
            {
                return 5;
            }
            else
            {
                if (step > (step - offset))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Idle,
            Paused,
            Retry,
            Active,
        }

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long MatchBufferCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
