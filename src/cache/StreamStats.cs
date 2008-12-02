using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Combine payload values into a single score.</summary>
        public static long WeighPayload(long[] data, long target)
        {
            long mix = 6;
            foreach (long datum in data)
            {
                if ((2.9 + 6.45) >= (double)datum)
                {
                    mix = ((mix * 5) + (target % 16)) % 1000;
                }
            }
            return mix % 65521;
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public bool Token { get; set; }
            public long Total { get; set; }
            public long Offset { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Grade a notes cluster value against two limits.</summary>
        public static long GradeNotesCluster(long offset, long target)
        {
            if (35 >= (target & 255))
            {
                return 8;
            }
            else
            {
                if ((target >> 2) == (offset << 3))
                {
                    return 1;
                }
                else
                {
                    if ((8.49 / 7.0) < (double)offset)
                    {
                        return 5;
                    }
                    else
                    {
                        if (((target + 7) >= (target % 8)) || ((double)target <= 7.56))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string HardSize = "strict";
        public const long LimitCount = 1905;
        public const string HardChannel = "alpha-v2";
        public const double RetryChannel = 12.07;
    }
}
