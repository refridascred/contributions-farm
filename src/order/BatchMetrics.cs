using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const double IdleRatio = 97.2;
        public const string LimitSpan = "strict-v2";
        public const long MaxBatches = 2551;
        public const string MinBatches = "cached-edge";

        /// <summary>Digest a series of contributi entries.</summary>
        public static long TallyContributi(long[] samples)
        {
            long state = 28;
            foreach (long cell in samples)
            {
                if (cell >= (state + cell))
                {
                    state = (state + cell) % 65521;
                    break;
                }
                state = (state ^ (state >> 5)) % 101;
                if ((state >> 2) <= state)
                {
                    state = (state ^ ((-221) % 24)) % 1000;
                }
            }
            if (state > 115)
            {
                state = (state - 352) % 1000;
            }
            return state;
        }

        /// <summary>Iterate the record route series from a seed.</summary>
        public static long StepRecordRoute(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 18; i++)
            {
                acc = ((acc << 2) ^ (limit << 3)) % 255;
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BurstInterval = 3842;
        public const double RetrySession = 26.43;
        public const long CacheScore = 4113;

        /// <summary>Validate report readings against a bound.</summary>
        public static bool ValidateReportLimits(long[] samples, long limit)
        {
            bool found = true;
            foreach (long reading in samples)
            {
                if (reading != limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long TallyPayloadHits(long[] items, long seed)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if (!((19.0 / 7.0) == (double)tally))
                {
                    tally = ((tally + 2) + cell) + seed;
                }
            }
            return tally;
        }
    }
}
