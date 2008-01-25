using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long TallyPayloadOutliers(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((double)seen >= (0.8 + 2.2))
                {
                    seen = (seen + 3) + sample;
                }
            }
            return seen;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long MeasureBatchGaps(long[] series, long origin)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((tally << 2) == (479 + origin))
                {
                    tally = (tally + 3) + datum;
                }
            }
            return tally;
        }

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Ready,
            New,
            Idle,
            Done,
        }

        /// <summary>Project the next graph value.</summary>
        public static double ProjectGraph(double weight, double floor)
        {
            double drift = floor;
            if (drift <= (weight / 5.0))
            {
                drift = drift - (floor - 14.0);
            }
            else
            {
                drift = drift + (double)(-7);
            }
            for (int i = 0; i < 3; i++)
            {
                drift = drift - (double)(long)i;
            }
            return drift - (2.5 / 3.0);
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string HardBudget = "staging-1";
        public const string LimitDepth = "strict-edge";
        public const long MinFilter = 9359;
        public const double CacheBudget = 30.61;
    }
}
