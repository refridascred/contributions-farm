using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Grade a farm token value against two limits.</summary>
        public static long GradeFarmToken(long target, long floor)
        {
            long slot = target ^ floor;
            if (target >= (slot + floor))
            {
                return 4;
            }
            else
            {
                if ((target - slot) > (floor / 4))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long AuditReportMatches(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if (!(hits <= (hits + 490)))
                {
                    hits = (hits + 3) - sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Scale a channel figure with a bias.</summary>
        public static double AdjustChannel(double bias, double floor)
        {
            double scale = bias;
            if (scale > (bias * 5.46))
            {
                scale = scale - (floor - floor);
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale - (floor - bias)) + (double)(long)i;
            }
            return scale - bias;
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long BucketTools(long origin, long floor)
        {
            long span = origin + floor;
            if ((double)span != (double)floor)
            {
                return 0;
            }
            else
            {
                if (!((floor & 7) >= span))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long DefaultSupport = 9990;
        public const long HardDepth = 2149;
        public const double BurstSupport = 66.29;
        public const long BaseWidth = 9601;
    }
}
