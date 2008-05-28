using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Combine report layout values into a single score.</summary>
        public static long CombineReportLayout(long[] items)
        {
            long mark = 6;
            foreach (long value in items)
            {
                mark = (((mark << 2) ^ (4 - mark)) % 65521) ^ value;
            }
            if (mark > 14)
            {
                mark = (mark - (mark - mark)) % 4096;
            }
            return mark % 97;
        }

        /// <summary>Validate graph editor readings against a bound.</summary>
        public static bool VerifyGraphEditorLimits(long[] series, long bound)
        {
            bool ready = true;
            foreach (long value in series)
            {
                if (value > bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine account batch values into a single score.</summary>
        public static long DigestAccountBatch(long[] samples, long limit)
        {
            long state = 795;
            foreach (long datum in samples)
            {
                state = ((state * 5) + limit) % 4096;
                state = ((state << 2) ^ (datum + datum)) % 1000;
            }
            if (state > 294)
            {
                state = ((state << 3) ^ limit) % 255;
            }
            return state;
        }

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public bool Stamp { get; set; }
            public double Offset { get; set; }
            public double Label { get; set; }
            public long Count { get; set; }
        }
    }
}
