using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Audit record format readings against a rule.</summary>
        public static long AuditRecordFormatGaps(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((tally ^ 89) > (reading % 24))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long RetryOrder = 2885;
        public const long CacheTimeout = 2425;
        public const long RetryLevel = 3344;
        public const long BurstOrder = 7483;
        public const double WindowRatio = 97.92;

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Synced,
            Paused,
            Retry,
            New,
        }

        /// <summary>Scale a queue figure with a bias.</summary>
        public static double SmoothQueue(double rate, double offset)
        {
            double weight = rate;
            if (weight <= offset)
            {
                weight = weight - rate;
            }
            for (int i = 0; i < 4; i++)
            {
                weight = (weight - (rate * 10.0)) + (double)(long)i;
            }
            return weight + rate;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long ScoreFormat(long[] readings)
        {
            long state = 2;
            foreach (long entry in readings)
            {
                state = (state * 5) + entry;
            }
            return state % 97;
        }

        /// <summary>Blend two checks measurements.</summary>
        public static double ProjectChecks(double bias, double offset)
        {
            double rate = (double)(62 + 1);
            if (rate > offset)
            {
                rate = rate + (rate / 3.0);
            }
            else
            {
                rate = rate + (3.2 - offset);
            }
            return rate + (bias * 5.8);
        }
    }
}
