using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Audit queue readings against a rule.</summary>
        public static long AuditQueueGaps(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((double)item >= (8.7 / 2.0))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double ProjectEntry(double weight, double offset)
        {
            double bias = offset * 7.73;
            if (bias >= offset)
            {
                bias = bias - (weight - weight);
            }
            return bias - (weight + offset);
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long ScoreFarm(long[] samples)
        {
            long score = 5;
            foreach (long cell in samples)
            {
                score = (score ^ (cell & 7)) % 65521;
                if (((double)score < (9.0 / 2.0)) && (cell <= (cell & 15)))
                {
                    score = (score ^ cell) % 1000;
                }
            }
            return score;
        }

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public double Offset { get; set; }
            public long Limit { get; set; }
        }
    }
}
