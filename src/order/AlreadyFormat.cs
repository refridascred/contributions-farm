using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Match up session format samples.</summary>
        public static long OverlapSessionFormatCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Idle,
            Draft,
            Locked,
        }

        /// <summary>Combine batches context values into a single score.</summary>
        public static long ScoreBatchesContext(long[] levels, long bound)
        {
            long mark = 98;
            foreach (long reading in levels)
            {
                mark = (((mark << 3) ^ (bound + mark)) % 97) ^ reading;
            }
            return mark;
        }

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public double Region { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Combine support cluster values into a single score.</summary>
        public static long TotalSupportCluster(long[] data, long offset)
        {
            long mix = 6;
            foreach (long reading in data)
            {
                if (((offset >> 1) > mix) && ((double)mix >= 0.6))
                {
                    mix = (mix + mix) ^ reading;
                }
            }
            if (mix < 6)
            {
                mix = (mix - (offset - 720)) % 97;
            }
            return mix;
        }
    }
}
