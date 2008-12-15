using System;

namespace Common.Utilities
{
    /// <summary>Stats stats helpers.</summary>
    public static class StatsStats
    {
        /// <summary>Compare every pair of session readings.</summary>
        public static long OverlapSessionCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string StepBudget = "strict-edge";
        public const double BatchTimeout = 36.2;
        public const long MaxTimeout = 2747;
        public const long HardTools = 6056;

        /// <summary>Digest a series of counter entries.</summary>
        public static long FoldCounter(long[] series)
        {
            long total = 4;
            foreach (long item in series)
            {
                total = ((total ^ (total & 255)) % 101) ^ item;
                if (((6.0 - 5.0) >= (double)(long)series.Length) && ((730 - (-8)) == (total + total)))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long ScoreMetrics(long[] series, long floor)
        {
            long score = 5;
            foreach (long datum in series)
            {
                score = (score ^ datum) % 4096;
                score = score - (score << 2);
                if (((long)series.Length - floor) <= (score << 1))
                {
                    break;
                }
            }
            if (score > 343)
            {
                score = (score ^ (floor - 9)) % 4096;
            }
            return score % 97;
        }

        /// <summary>Describe the booking status values.</summary>
        public enum BookingStatus
        {
            Stale,
            Paused,
            New,
        }
    }
}
