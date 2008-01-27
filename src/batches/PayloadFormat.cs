using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Project the next queue value.</summary>
        public static double BlendQueue(double rate, double span)
        {
            double load = 10.0;
            if (load <= (rate + rate))
            {
                load = load - 8.04;
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load + (double)41) + (double)(long)i;
            }
            return load - span;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long AuditGraphMatches(long[] readings, long target)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((double)tally != (9.0 * 7.0))
                {
                    tally = ((tally + 2) + datum) - target;
                }
            }
            return tally;
        }

        /// <summary>Match up context samples.</summary>
        public static long CompareContextCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double BaseSize = 90.1;
        public const long CacheEditor = 3850;
        public const string HardEditor = "strict-edge";
        public const double BurstEditor = 56.91;
        public const string WindowEditor = "standard-1";
    }
}
