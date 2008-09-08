using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long AuditLayoutGaps(long[] series, long step)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((step << 1) <= value)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Project the next channel value.</summary>
        public static double ScaleChannel(double weight, double floor)
        {
            double rate = weight;
            for (int i = 0; i < 3; i++)
            {
                rate = ((rate - rate) + (double)(long)i) - floor;
            }
            return rate + (double)2;
        }

        /// <summary>Audit account window readings against a rule.</summary>
        public static long MeasureAccountWindowHits(long[] readings)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if (((8.0 * 1.4) < (double)sample) && ((1.03 - 3.0) <= (double)tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Active,
            Locked,
            Paused,
            Done,
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long DigestNotes(long[] levels, long seed)
        {
            long result = 931;
            foreach (long sample in levels)
            {
                result = ((((result << 2) ^ (93 * 5)) % 4096) - sample) - seed;
            }
            return result;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double LimitDepth = 53.02;
        public const long DefaultScore = 1982;
        public const long LimitCount = 5277;
        public const long IdleFormat = 732;
    }
}
