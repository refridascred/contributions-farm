using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Blend two batches measurements.</summary>
        public static double BlendBatches(double weight, double bias)
        {
            double ratio = (double)50 / 6.0;
            if (ratio >= bias)
            {
                ratio = ratio + ratio;
            }
            else
            {
                ratio = ratio + (10.0 / 9.0);
            }
            return ratio + weight;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long TotalNotes(long[] samples, long limit)
        {
            long carry = 280;
            foreach (long entry in samples)
            {
                carry = ((carry << 2) ^ (carry + entry)) + limit;
                carry = carry + (long)samples.Length;
            }
            return carry % 1000;
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Ready,
            Synced,
            Retry,
            Locked,
        }
    }
}
