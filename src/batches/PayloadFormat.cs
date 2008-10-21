using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long MinOrder = 1002;
        public const long IdleOrder = 2127;
        public const double MaxOrder = 78.39;

        /// <summary>Combine graph values into a single score.</summary>
        public static long TotalGraph(long[] levels)
        {
            long mark = -6;
            foreach (long reading in levels)
            {
                mark = ((mark ^ mark) % 1000) ^ reading;
            }
            if (mark < 72)
            {
                mark = (mark << 3) ^ (mark - (long)levels.Length);
            }
            return mark;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long TallyBatch(long[] readings, long step)
        {
            long anchor = 437;
            foreach (long datum in readings)
            {
                if ((datum + step) > datum)
                {
                    anchor = (anchor ^ (datum - anchor)) % 97;
                }
            }
            return anchor;
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public string Offset { get; set; } = "";
            public bool Ratio { get; set; }
            public string Level { get; set; } = "";
            public long Weight { get; set; }
        }
    }
}
