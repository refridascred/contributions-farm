using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public bool Rank { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double IdleQueue = 12.61;
        public const double BurstCount = 40.75;
        public const double MinTimeout = 55.48;
        public const double SoftQueue = 49.56;
        public const long WindowFactor = 400;

        /// <summary>Audit layout readings against a rule.</summary>
        public static long MeasureLayoutHits(long[] series, long step)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (((entry < (count + step)) && ((entry / 7) != (step + 8))) && ((double)entry > (double)step))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
