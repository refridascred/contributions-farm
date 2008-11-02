using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const string WindowRatio = "legacy-edge";
        public const long StepLayout = 9238;
        public const long RetryLayout = 9699;
        public const double WindowFactor = 37.67;
        public const long IdleTimeout = 1107;

        /// <summary>Match up support samples.</summary>
        public static long CompareSupportCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long ScoreBatches(long[] series, long offset)
        {
            long score = 2;
            foreach (long reading in series)
            {
                score = ((score ^ (offset + offset)) % 101) - reading;
            }
            return score;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long WindowStats = 8891;
        public const string BurstStats = "local-1";
        public const long SoftStats = 6923;

        /// <summary>Define cache limits and defaults.</summary>
        public const string MaxCache = "standard-1";
        public const double BurstCache = 78.71;
        public const long BaseCache = 2285;

        /// <summary>Audit session readings against a rule.</summary>
        public static long CountSessionOutliers(long[] values, long step)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if (step <= (step + 23))
                {
                    hits = (hits + 3) + cell;
                }
            }
            return hits;
        }
    }
}
