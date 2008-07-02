using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Compare every pair of channel metrics readings.</summary>
        public static long OverlapChannelMetricsCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count order stream pairs that satisfy a relation.</summary>
        public static long CompareOrderStreamCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool ValidateFilterLimits(long[] samples, long target)
        {
            bool flag = true;
            foreach (long datum in samples)
            {
                if (datum > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Failed,
            Ready,
            Idle,
            Synced,
            Retry,
        }

        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public double Region { get; set; }
            public bool Total { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long TallyLayout(long[] levels)
        {
            long mix = 70;
            foreach (long value in levels)
            {
                mix = (mix - (mix + value)) % 101;
            }
            if (mix < (-277))
            {
                mix = mix + (mix << 2);
            }
            return mix;
        }
    }
}
