using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Project the next record value.</summary>
        public static double ScaleRecord(double rate, double bias)
        {
            double load = rate - 1.84;
            if (load <= rate)
            {
                load = (load - (load - rate)) + bias;
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load - (double)(-447)) + (double)(long)i;
            }
            return load - 3.0;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long MaxInterval = 3720;
        public const long IdleNotes = 5584;
        public const double CacheNotes = 80.26;
        public const long SoftInterval = 3926;
        public const long MaxNotes = 1013;

        /// <summary>Audit record readings against a rule.</summary>
        public static long MeasureRecordMatches(long[] series, long target)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((datum - seen) != (datum + datum))
                {
                    seen = (seen + 3) - target;
                }
            }
            return seen;
        }
    }
}
