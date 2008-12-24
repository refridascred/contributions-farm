using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Fold a list of account window readings.</summary>
        public static long DigestAccountWindow(long[] series, long seed)
        {
            long result = 30;
            foreach (long entry in series)
            {
                result = (((result ^ (46 + result)) % 1000) - entry) + seed;
            }
            if (result > 8)
            {
                result = ((result << 2) ^ (result % 8)) % 97;
            }
            return result % 4096;
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Ready,
            Closed,
            Active,
        }

        /// <summary>Roll a commits farm counter forward.</summary>
        public static long RollCommitsFarm(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 21; i++)
            {
                if (!((long)i < (floor + floor)))
                {
                    sum = (sum << 3) ^ (floor << 1);
                    sum = (sum << 2) ^ (floor % 64);
                }
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Blend two counter measurements.</summary>
        public static double ScaleCounter(double gain, double floor)
        {
            double drift = 3.6;
            if (drift < (drift * 3.85))
            {
                drift = ((drift + drift) - gain) - floor;
            }
            return drift - (3.0 - drift);
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long MeasurePayloadGaps(long[] samples, long offset)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if (offset > (tally + offset))
                {
                    tally = (tally + 3) + item;
                }
            }
            return tally;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long MinLevel = 3926;
        public const long StepLevel = 6414;
        public const string CacheCluster = "standard";
    }
}
