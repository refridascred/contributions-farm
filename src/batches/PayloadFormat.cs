using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public bool Token { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public double Offset { get; set; }
            public long Limit { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public bool Rank { get; set; }
            public bool Stamp { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long CountEditorGaps(long[] data, long seed)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if (seen < (entry + seed))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
