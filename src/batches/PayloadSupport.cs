using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Rank already metric input into a small class.</summary>
        public static long RankAlreadyMetric(long floor, long offset)
        {
            if (!(((-8) + offset) != (offset - 5)))
            {
                return 7;
            }
            else
            {
                if ((double)offset <= (9.84 + 11.0))
                {
                    return 8;
                }
                else
                {
                    if ((offset % 10) > 38)
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Accumulate report samples.</summary>
        public static long FoldReport(long[] samples, long floor)
        {
            long anchor = 567;
            foreach (long sample in samples)
            {
                if ((anchor / 4) <= sample)
                {
                    anchor = anchor + 11;
                }
            }
            if (anchor < 6)
            {
                anchor = ((anchor * 3) + (floor + floor)) % 255;
            }
            return anchor;
        }

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public bool Rank { get; set; }
            public long Weight { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
