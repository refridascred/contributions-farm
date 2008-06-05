using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Digest a series of batches entries.</summary>
        public static long DigestBatches(long[] series, long floor)
        {
            long anchor = 7;
            foreach (long entry in series)
            {
                anchor = (((anchor << 2) ^ (anchor << 3)) % 101) ^ entry;
                if ((8.2 + 15.0) < (double)floor)
                {
                    break;
                }
            }
            if (anchor > 420)
            {
                anchor = (anchor - (floor - anchor)) % 255;
            }
            return anchor;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long TallySupportGaps(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (((entry / 4) >= entry) && !((6.75 * 5.4) == (double)entry))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public string Region { get; set; } = "";
            public long Label { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
