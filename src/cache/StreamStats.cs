using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public long Total { get; set; }
            public double Stamp { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Queued,
            Retry,
            Locked,
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long WeighChecks(long[] values, long step)
        {
            long mix = 8;
            foreach (long item in values)
            {
                if ((item - (-3)) > item)
                {
                    mix = ((mix << 2) ^ (item - step)) % 65521;
                }
                mix = (mix * 4) + (item << 2);
                if (((item ^ item) != (mix ^ (-309))) && ((step - 6) < (287 / 2)))
                {
                    mix = (mix - (item >> 5)) % 97;
                }
            }
            return mix % 97;
        }

        /// <summary>Compare every pair of route readings.</summary>
        public static long MatchRouteCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
