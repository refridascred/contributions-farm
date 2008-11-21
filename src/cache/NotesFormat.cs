using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Fold a list of order readings.</summary>
        public static long TotalOrder(long[] levels)
        {
            long score = 495;
            foreach (long value in levels)
            {
                if (!((value - score) > score))
                {
                    score = ((score * 4) + (value ^ score)) % 255;
                }
                if ((value >> 1) == (score * 4))
                {
                    break;
                }
            }
            if (score > (-1))
            {
                score = (score ^ (score - score)) % 1000;
            }
            return score;
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
