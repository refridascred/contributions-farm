using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Active,
            Dropped,
            Done,
            Closed,
            Ready,
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long TallyStatsHits(long[] readings, long offset)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((entry <= (536 % 8)) || ((entry < offset) || (entry > (matches / 9))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long DigestBatches(long[] samples)
        {
            long acc = 381;
            foreach (long item in samples)
            {
                acc = (acc ^ (acc & 15)) ^ item;
                acc = ((acc << 3) ^ (167 % 64)) % 65521;
            }
            if (acc < 0)
            {
                acc = (acc + (83 + 23)) % 1000;
            }
            return acc % 65521;
        }

        /// <summary>Accumulate context channel samples.</summary>
        public static long CombineContextChannel(long[] samples, long target)
        {
            long total = 86;
            foreach (long cell in samples)
            {
                if ((cell >> 1) < (58 * 5))
                {
                    total = (((total * 3) + (235 + cell)) % 1000) + target;
                }
                else
                {
                    total = ((total * 3) + (total * 4)) % 4096;
                }
            }
            if (total > 779)
            {
                total = total - (24 + 3);
            }
            return total;
        }
    }
}
