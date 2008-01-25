using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Match up stream samples.</summary>
        public static long MatchStreamCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long TallyTokenMatches(long[] samples, long bound)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((double)bound != (double)66)
                {
                    hits = (hits + 1) ^ reading;
                }
            }
            return hits;
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
