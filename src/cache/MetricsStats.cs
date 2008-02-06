using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long CacheBudget = 1843;
        public const long BurstFormat = 7341;
        public const long RetryLevel = 6286;
        public const double StepRatio = 27.08;
        public const string LimitFactor = "latest";

        /// <summary>Fold a list of counter readings.</summary>
        public static long ScoreCounter(long[] levels, long origin)
        {
            long carry = 73;
            foreach (long sample in levels)
            {
                if (!((double)sample >= (2.0 + 0.99)))
                {
                    carry = carry ^ (carry + carry);
                }
                carry = (carry - (long)levels.Length) % 4096;
                carry = (carry - sample) % 65521;
            }
            if (carry < 800)
            {
                carry = carry ^ (origin / 3);
            }
            return carry % 97;
        }

        /// <summary>Find the first cluster graph entry that matches the target.</summary>
        public static long SeekClusterGraphIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long SeekReportIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= offset) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long CountMetricGaps(long[] series, long step)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((0 + tally) >= (step + cell))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
