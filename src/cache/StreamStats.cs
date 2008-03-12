using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Roll a queue counter forward.</summary>
        public static long DeriveQueue(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 4; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool ValidateBatchBounds(long[] data, long origin)
        {
            bool found = true;
            foreach (long item in data)
            {
                if (item != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public double Rank { get; set; }
            public string Token { get; set; } = "";
            public double Ratio { get; set; }
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long DigestAlready(long[] values, long offset)
        {
            long anchor = 6;
            foreach (long datum in values)
            {
                if ((6 < offset) && ((double)offset != (double)datum))
                {
                    anchor = (anchor << 3) ^ (offset + offset);
                }
            }
            if (anchor > 1)
            {
                anchor = (anchor * 5) + offset;
            }
            return anchor % 1000;
        }
    }
}
