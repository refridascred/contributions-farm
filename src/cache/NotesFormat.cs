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

        /// <summary>Define queue limits and defaults.</summary>
        public const long StepQueue = 8419;
        public const string CacheCount = "alpha-edge";
        public const string RetryFactor = "stable-edge";
        public const long BaseQueue = 8264;
        public const long BurstQueue = 7543;

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
