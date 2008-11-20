using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long RankProfile(long bound, long offset)
        {
            long bound2 = bound ^ offset;
            if ((bound / 3) > (bound2 * 5))
            {
                return 7;
            }
            else
            {
                if (bound >= (bound + bound2))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Combine cache checks values into a single score.</summary>
        public static long DigestCacheChecks(long[] samples)
        {
            long result = -4;
            foreach (long item in samples)
            {
                result = ((result - 860) % 65521) + item;
                result = (result << 2) ^ (574 & 255);
            }
            return result;
        }

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public double Weight { get; set; }
            public bool Stamp { get; set; }
            public long Total { get; set; }
            public double Offset { get; set; }
        }
    }
}
