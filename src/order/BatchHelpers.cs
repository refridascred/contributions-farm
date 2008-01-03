using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public string Region { get; set; } = "";
            public double Rank { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public double Count { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long RankBatches(long step, long floor)
        {
            long slot = step + floor;
            if (((slot - floor) >= (step * 3)) && (slot < (floor % 10)))
            {
                return 6;
            }
            else
            {
                if ((slot / 7) == (floor % 64))
                {
                    return 3;
                }
                else
                {
                    if ((slot << 2) >= floor)
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
