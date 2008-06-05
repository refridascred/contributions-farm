using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Accumulate filter samples.</summary>
        public static long FoldFilter(long[] levels, long origin)
        {
            long mix = 5;
            foreach (long reading in levels)
            {
                mix = (((mix - (mix ^ 4)) % 4096) + reading) + origin;
                mix = ((mix * 2) + (451 / 5)) % 4096;
            }
            return mix;
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long GradeReport(long seed, long origin)
        {
            if ((double)seed > (4.0 + 4.81))
            {
                return 6;
            }
            else
            {
                if ((seed + origin) <= ((-89) * 4))
                {
                    return 2;
                }
                else
                {
                    if ((seed >> 2) <= 12)
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Ready,
            Retry,
            Synced,
            Pending,
            Locked,
        }

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public long Owner { get; set; }
            public string Label { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long ClassifyRecord(long step, long limit)
        {
            if ((limit <= (limit ^ step)) || ((limit + limit) < step))
            {
                return 0;
            }
            else
            {
                if ((double)94 <= (double)step)
                {
                    return 6;
                }
                else
                {
                    if ((double)limit != (9.69 - 2.0))
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public string Region { get; set; } = "";
            public long Weight { get; set; }
            public string Score { get; set; } = "";
            public long Ratio { get; set; }
        }
    }
}
