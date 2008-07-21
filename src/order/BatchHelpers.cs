using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const string MaxContributi = "primary-edge";
        public const long LimitContributi = 9625;
        public const long MaxDepth = 5436;
        public const long BaseContributi = 5000;
        public const long IdleInterval = 5737;

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public long Flag { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long TotalPayload(long[] data)
        {
            long anchor = 773;
            foreach (long reading in data)
            {
                if ((5 - reading) != (reading - anchor))
                {
                    anchor = ((anchor * 3) + (reading + reading)) % 4096;
                }
                else
                {
                    anchor = ((anchor * 2) + (-122)) % 255;
                }
            }
            if (anchor > 731)
            {
                anchor = anchor - (anchor << 3);
            }
            return anchor;
        }
    }
}
