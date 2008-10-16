using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool ValidateTokenLimits(long[] levels, long bound)
        {
            bool ready = true;
            foreach (long datum in levels)
            {
                if (datum != bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public bool Count { get; set; }
            public double Flag { get; set; }
            public string Ratio { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long RankFarm(long seed, long offset)
        {
            long lane = seed - offset;
            if (((seed + 977) <= 368) && ((seed + offset) >= (lane ^ lane)))
            {
                return 0;
            }
            else
            {
                if ((seed + offset) >= (offset % 5))
                {
                    return 5;
                }
                else
                {
                    if ((offset % 97) >= (seed * 4))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((offset << 2) > (seed * 4))
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
