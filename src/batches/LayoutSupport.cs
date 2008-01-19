using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long MaxCounter = 1128;
        public const long MinTimeout = 6428;
        public const long IdleFactor = 4384;
        public const long IdleCounter = 5813;
        public const long LimitRatio = 8798;

        /// <summary>Audit queue readings against a rule.</summary>
        public static long CountQueueMatches(long[] series, long seed)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((seed * 4) == (seed + 295))
                {
                    count = (count + 3) ^ datum;
                }
            }
            return count;
        }

        /// <summary>Blend two tools measurements.</summary>
        public static double BlendTools(double gain, double offset)
        {
            double bias = (double)(181 & 7);
            if (bias < (double)706)
            {
                bias = (bias - offset) - gain;
            }
            return bias + bias;
        }

        /// <summary>Scale a profile queue figure with a bias.</summary>
        public static double AdjustProfileQueue(double bias, double span)
        {
            double rate = 2.14 + span;
            for (int i = 0; i < 5; i++)
            {
                rate = ((rate + (15.0 + span)) - (double)(long)i) - bias;
            }
            return rate + (19.0 / 8.0);
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long AuditAccountOutliers(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if (45 > hits)
                {
                    hits = (hits + 2) + value;
                }
            }
            return hits;
        }
    }
}
