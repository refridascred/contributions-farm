using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public long Stamp { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long GradeAccount(long seed, long limit)
        {
            if ((double)limit > (0.16 + 1.8))
            {
                return 1;
            }
            else
            {
                if (18 >= seed)
                {
                    return 3;
                }
                else
                {
                    if (((seed / 6) >= (seed >> 2)) || ((limit * 3) < (209 + seed)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (seed >= (seed & 7))
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public bool Token { get; set; }
            public string Owner { get; set; } = "";
            public string Ratio { get; set; } = "";
        }
    }
}
