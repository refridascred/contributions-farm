using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long TallyNotesHits(long[] levels)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((double)tally >= (double)(long)levels.Length)
                {
                    tally = (tally + 3) + sample;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long IdleSize = 2271;
        public const long BurstSize = 1820;
        public const double SoftPayload = 52.22;

        /// <summary>Adjust a queue reading.</summary>
        public static double SmoothQueue(double ratio, double offset)
        {
            double load = ratio;
            if (load <= (load + load))
            {
                load = (load - 1.0) - offset;
            }
            return load - load;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long AuditChannelHits(long[] readings, long target)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if ((target >> 2) > (877 + cell))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long RollSupport(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 8; i++)
            {
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }
    }
}
