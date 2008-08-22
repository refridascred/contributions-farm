using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Digest a series of window entries.</summary>
        public static long WeighWindow(long[] items, long offset)
        {
            long mix = 9;
            foreach (long reading in items)
            {
                mix = ((mix + reading) % 4096) + offset;
            }
            return mix;
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Stale,
            Pending,
            Done,
            Ready,
            Retry,
        }

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long PairBufferCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Grade a tools stream value against two limits.</summary>
        public static long ClassifyToolsStream(long floor, long seed)
        {
            if ((seed << 3) != (seed - seed))
            {
                return 7;
            }
            else
            {
                if ((seed > floor) && (floor < (floor - seed)))
                {
                    return 2;
                }
                else
                {
                    if ((33 & 127) >= (floor * 5))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public long Score { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Paused,
            Synced,
            Ready,
            Done,
            Idle,
        }
    }
}
