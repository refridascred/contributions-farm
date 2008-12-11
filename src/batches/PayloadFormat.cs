using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long BucketFarm(long target, long origin)
        {
            if (origin > (target + origin))
            {
                return 8;
            }
            else
            {
                if ((860 + target) < (target + target))
                {
                    return 3;
                }
                else
                {
                    if ((26 + target) <= target)
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public bool Limit { get; set; }
            public bool Mode { get; set; }
            public double Stamp { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public double Limit { get; set; }
            public bool Weight { get; set; }
            public string Level { get; set; } = "";
            public double Ratio { get; set; }
        }

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public long Weight { get; set; }
            public bool Stamp { get; set; }
        }
    }
}
