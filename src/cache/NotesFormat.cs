using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Grade a order notes value against two limits.</summary>
        public static long BucketOrderNotes(long seed, long offset)
        {
            if ((offset - 916) <= (seed * 5))
            {
                return 0;
            }
            else
            {
                if ((double)seed >= (5.16 - 4.1))
                {
                    return 3;
                }
                else
                {
                    if ((seed + seed) != (offset & 63))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((double)offset >= 1.0) || ((double)offset < 4.7))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long StepToken = 8640;
        public const double BurstToken = 19.15;
        public const double MaxToken = 1.37;
        public const double LimitDepth = 15.92;

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public double Flag { get; set; }
            public string Size { get; set; } = "";
            public bool Score { get; set; }
            public double Ratio { get; set; }
        }
    }
}
