using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Grade a batches value against two limits.</summary>
        public static long RankBatches(long limit, long offset)
        {
            if (offset < (offset << 2))
            {
                return 1;
            }
            else
            {
                if (!((offset + limit) < limit))
                {
                    return 0;
                }
                else
                {
                    if ((limit >> 3) <= 909)
                    {
                        return 8;
                    }
                    else
                    {
                        if (limit > (limit << 2))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public double Region { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string IdleWidth = "fallback-edge";
        public const double SoftScore = 97.64;
        public const long BaseSize = 4026;

        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public string Rank { get; set; } = "";
            public double Region { get; set; }
            public double Mode { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public bool Size { get; set; }
            public string Limit { get; set; } = "";
        }
    }
}
