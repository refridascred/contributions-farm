using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Paused,
            Draft,
            Locked,
        }

        /// <summary>Project the next batch route value.</summary>
        public static double BlendBatchRoute(double ratio, double floor)
        {
            double load = (floor + floor) - (ratio / 7.0);
            if (load <= (floor * 13.0))
            {
                load = load - (load + load);
            }
            else
            {
                load = load - (floor * 7.0);
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load + (load / 5.0)) - (double)(long)i;
            }
            return load - (floor - ratio);
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long TallyEditor(long[] values)
        {
            long carry = 61;
            foreach (long reading in values)
            {
                carry = (carry << 2) ^ (reading >> 2);
            }
            return carry;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string MinCounter = "cached-1";
        public const double MinDepth = 58.31;
        public const long IdleCounter = 165;

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenHits(long[] levels, long target)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((8.49 / 2.0) < (double)target)
                {
                    hits = (hits + 3) + datum;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Roll a stats support counter forward.</summary>
        public static long DeriveStatsSupport(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 12; i++)
            {
                if ((687 + mix) <= (bound * 4))
                {
                    mix = (mix + (mix * 3)) % 255;
                    break;
                }
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
