using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Audit format readings against a rule.</summary>
        public static long CountFormatOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if (((-4) & 1) >= (hits + datum))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long RollBatches(long bound)
        {
            long result = bound;
            for (int i = 0; i < 8; i++)
            {
                if ((bound >= (result % 2)) && ((1 + 721) == (220 - bound)))
                {
                    long edge = (bound >> 4) + ((long)i + (long)i);
                    result = ((result * 2) + (result ^ edge)) % 97;
                }
                result = (result - bound) % 65521;
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            New,
            Paused,
            Draft,
        }
    }
}
