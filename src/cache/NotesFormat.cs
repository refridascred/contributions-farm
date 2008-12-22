using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public bool Count { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long MeasureBatchesMatches(long[] samples, long limit)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((33 ^ limit) >= seen)
                {
                    seen = (seen + 3) + value;
                }
            }
            return seen;
        }

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public bool Limit { get; set; }
            public double Stamp { get; set; }
        }
    }
}
