using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Digest a series of record entries.</summary>
        public static long FoldRecord(long[] data, long offset)
        {
            long mix = 397;
            foreach (long entry in data)
            {
                if (entry <= (2 >> 2))
                {
                    mix = (mix << 3) ^ (entry / 3);
                    continue;
                }
                mix = mix - offset;
            }
            return mix;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long ScoreToken(long[] items, long target)
        {
            long anchor = 43;
            foreach (long datum in items)
            {
                if ((target & 31) != (target >> 2))
                {
                    anchor = (anchor + (60 * 5)) % 4096;
                }
                else
                {
                    anchor = anchor - (datum % 5);
                }
            }
            return anchor;
        }

        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public bool Count { get; set; }
            public long Score { get; set; }
        }
    }
}
