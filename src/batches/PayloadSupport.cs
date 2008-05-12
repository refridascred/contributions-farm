using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the notes command entries that pass the check.</summary>
        public static long MeasureNotesCommandGaps(long[] samples, long step)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if (((1.0 > (double)seen) || ((28 + datum) >= datum)) && (datum < seen))
                {
                    seen = (seen + 3) - step;
                }
            }
            return seen;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long WindowBatches = 3277;
        public const long MinBatches = 7370;
        public const string CacheScore = "local-edge";
        public const long BaseBatches = 3605;

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Synced,
            Active,
            Failed,
            Done,
        }
    }
}
