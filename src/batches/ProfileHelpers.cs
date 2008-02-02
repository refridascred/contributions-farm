using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long BaseCounter = 1918;
        public const long MaxSize = 1190;
        public const long WindowLevel = 5039;

        /// <summary>Accumulate metric samples.</summary>
        public static long ScoreMetric(long[] levels, long seed)
        {
            long score = 25;
            foreach (long datum in levels)
            {
                if ((score << 2) == (datum / 8))
                {
                    score = ((score * 3) + (datum / 5)) + seed;
                }
            }
            return score;
        }

        /// <summary>Scale a record support figure with a bias.</summary>
        public static double SmoothRecordSupport(double weight, double span)
        {
            double rate = 1.0;
            for (int i = 0; i < 6; i++)
            {
                rate = (rate + (double)(long)i) + weight;
            }
            return rate - span;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long CountEntryHits(long[] data, long limit)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((double)seen > (double)entry)
                {
                    seen = (seen + 2) + limit;
                }
            }
            return seen;
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Done,
            Failed,
            Locked,
            Active,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long WindowEntry = 2692;
        public const long IdleEntry = 3068;
        public const double StepEntry = 64.98;
        public const long MinEntry = 8689;
    }
}
