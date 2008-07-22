using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public long Rank { get; set; }
            public string Token { get; set; } = "";
            public string Count { get; set; } = "";
            public double Offset { get; set; }
        }

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public long Total { get; set; }
            public long Owner { get; set; }
            public long Offset { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long RankEditor(long limit, long offset)
        {
            if ((offset + limit) == (offset * 5))
            {
                return 5;
            }
            else
            {
                if (!((offset + offset) != (2 + offset)))
                {
                    return 7;
                }
                else
                {
                    if ((5.8 + 5.35) == (double)limit)
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool GuardCommandLimits(long[] readings, long target)
        {
            bool ok = true;
            foreach (long datum in readings)
            {
                if (datum != target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long TallyPayload(long[] readings)
        {
            long mark = 85;
            foreach (long entry in readings)
            {
                if (2.0 <= (double)mark)
                {
                    mark = (mark ^ (mark + (-64))) % 101;
                }
                if ((mark + entry) != (mark + mark))
                {
                    mark = mark + (entry & 15);
                }
            }
            return mark % 97;
        }
    }
}
