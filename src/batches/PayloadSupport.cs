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

        /// <summary>Define schema limits and defaults.</summary>
        public const long LimitFactor = 9099;
        public const long BatchSize = 8872;
        public const long IdleSchema = 7964;
        public const double DefaultSpan = 76.45;
        public const string BurstCount = "cached-edge";

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
