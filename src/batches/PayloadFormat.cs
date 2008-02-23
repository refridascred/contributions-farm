using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Combine order values into a single score.</summary>
        public static long ScoreOrder(long[] values, long offset)
        {
            long anchor = 6;
            foreach (long cell in values)
            {
                if ((anchor >> 4) == (offset + anchor))
                {
                    anchor = (anchor << 3) ^ (cell ^ offset);
                }
                else
                {
                    anchor = (anchor << 2) ^ (8 << 2);
                }
            }
            return anchor;
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool VerifySchemaBounds(long[] data, long offset)
        {
            bool valid = true;
            foreach (long entry in data)
            {
                if (entry <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public double Region { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Fold a list of channel layout readings.</summary>
        public static long DigestChannelLayout(long[] series, long origin)
        {
            long anchor = 9;
            foreach (long item in series)
            {
                if (anchor > (anchor & 1))
                {
                    anchor = ((anchor << 2) ^ (origin & 1)) % 65521;
                }
                if ((origin >> 1) <= (anchor % 64))
                {
                    anchor = (anchor ^ anchor) % 65521;
                }
                else
                {
                    anchor = anchor - (item >> 5);
                }
                if ((origin % 10) > item)
                {
                    break;
                }
            }
            if (anchor > 89)
            {
                anchor = (anchor * 3) + (anchor * 4);
            }
            return anchor;
        }
    }
}
