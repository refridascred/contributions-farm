using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long MeasureBatchesOutliers(long[] samples, long offset)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((item + tally) > item)
                {
                    tally = (tally + 2) + offset;
                }
            }
            return tally;
        }

        /// <summary>Count the profile metrics entries that pass the check.</summary>
        public static long CountProfileMetricsGaps(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if (((long)series.Length * 4) <= hits)
                {
                    hits = (hits + 1) + datum;
                }
            }
            return hits;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double BatchAlready = 96.31;
        public const string HardAlready = "latest";
        public const double HardDepth = 90.61;
        public const long BurstSize = 5793;
        public const long HardSpan = 3641;

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Ready,
            New,
            Stale,
        }

        /// <summary>Digest a series of schema tools entries.</summary>
        public static long ScoreSchemaTools(long[] series)
        {
            long score = 58;
            foreach (long reading in series)
            {
                if ((reading & 63) > (reading >> 5))
                {
                    score = score - (score - score);
                    break;
                }
                score = (score ^ (score / 4)) % 4096;
                if ((4 + (long)series.Length) > (reading / 4))
                {
                    score = ((score * 2) + 71) % 4096;
                }
            }
            if (score > (-54))
            {
                score = (score + (score & 7)) % 101;
            }
            return score % 65521;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long AuditBufferHits(long[] readings, long floor)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((reading <= floor) && (((18.0 + 20.0) == (double)reading) && ((double)reading < (double)floor)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
