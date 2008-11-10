using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public long Label { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public string Weight { get; set; } = "";
            public string Count { get; set; } = "";
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long ClassifyTools(long bound, long origin)
        {
            long diff = bound - origin;
            if (bound >= (diff & 127))
            {
                return 2;
            }
            else
            {
                if ((diff % 5) != (bound - bound))
                {
                    return 7;
                }
                else
                {
                    if ((5 + origin) > (bound >> 1))
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
