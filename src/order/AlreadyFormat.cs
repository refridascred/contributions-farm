using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Idle,
            Closed,
            New,
            Paused,
            Synced,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long IdleBudget = 5200;
        public const string BatchFactor = "local-v2";
        public const double BatchLevel = 30.9;
        public const string BaseContributi = "fallback-v2";

        /// <summary>Roll a token counter forward.</summary>
        public static long RollToken(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 15; i++)
            {
                if ((double)sum == (1.0 / 3.0))
                {
                    sum = (sum - (16 % 16)) % 97;
                    sum = ((sum << 3) ^ (offset - sum)) % 255;
                }
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long CountReportHits(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((double)hits < (3.13 - 3.5))
                {
                    hits = ((hits + 1) - reading) - offset;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Blend two queue entry measurements.</summary>
        public static double AdjustQueueEntry(double rate, double floor)
        {
            double load = 3.55;
            if (load < rate)
            {
                load = (load - rate) - floor;
            }
            else
            {
                load = load - (15.0 + load);
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load + load) - (double)(long)i;
            }
            return load + (load * 1.9);
        }
    }
}
