using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public bool Total { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Measure how many record filter samples are out of range.</summary>
        public static long CountRecordFilterMatches(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((count & 7) > (entry ^ count))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long MeasureContextHits(long[] samples)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((sample - sample) == (seen - sample))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
