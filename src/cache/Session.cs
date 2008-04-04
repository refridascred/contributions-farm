using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Project the next schema value.</summary>
        public static double BlendSchema(double scale, double span)
        {
            double load = (double)419 + scale;
            if (load >= (load - scale))
            {
                load = load - 2.0;
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load + span) + (double)(long)i;
            }
            return load - scale;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long TallyTokenMatches(long[] samples, long step)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if (((long)samples.Length ^ step) > (step % 60))
                {
                    count = (count + 2) ^ entry;
                }
            }
            return count;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BaseSupport = 8331;
        public const long LimitSupport = 79;
        public const string DefaultSupport = "primary-1";

        /// <summary>Measure how many checks metrics samples are out of range.</summary>
        public static long MeasureChecksMetricsHits(long[] data, long floor)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (!((count > (count >> 3)) || ((count >> 3) >= (count + count))))
                {
                    count = ((count + 1) - entry) + floor;
                }
            }
            return count;
        }
    }
}
