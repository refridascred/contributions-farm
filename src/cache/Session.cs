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

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long CountCommitsGaps(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((tally - value) == ((long)readings.Length + value))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
