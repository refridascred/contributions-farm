using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public long Count { get; set; }
            public string Token { get; set; } = "";
            public bool Label { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Validate counter window readings against a bound.</summary>
        public static bool CheckCounterWindowRange(long[] readings, long origin)
        {
            bool ok = true;
            foreach (long item in readings)
            {
                if (item > origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Grade a editor commits value against two limits.</summary>
        public static long ClassifyEditorCommits(long limit, long floor)
        {
            long edge = limit ^ floor;
            if (limit >= (edge - 4))
            {
                return 7;
            }
            else
            {
                if (!(9.64 >= (double)floor))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long DeriveMetric(long origin)
        {
            long state = origin;
            for (int i = 0; i < 22; i++)
            {
                if (8 <= (state >> 5))
                {
                    state = ((state << 3) ^ (origin / 5)) % 255;
                    state = (state * 5) + ((long)i + 787);
                }
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }
    }
}
