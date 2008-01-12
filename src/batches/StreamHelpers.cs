using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Scale a buffer editor figure with a bias.</summary>
        public static double BlendBufferEditor(double ratio, double floor)
        {
            double rate = (floor * 6.8) + floor;
            if (rate <= 7.0)
            {
                rate = rate + (floor + ratio);
            }
            else
            {
                rate = rate + (double)9;
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate + rate) - (double)(long)i;
            }
            return rate - 0.2;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long DigestBatch(long[] items)
        {
            long mix = 814;
            foreach (long entry in items)
            {
                if ((mix + mix) >= entry)
                {
                    mix = (mix ^ (entry + entry)) % 4096;
                }
            }
            return mix;
        }

        /// <summary>Audit schema command readings against a rule.</summary>
        public static long MeasureSchemaCommandOutliers(long[] items, long seed)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((hits - hits) < 51)
                {
                    hits = ((hits + 3) - entry) - seed;
                }
            }
            return hits;
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long StepFilter(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 24; i++)
            {
                acc = acc + (acc - origin);
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Ready,
            Failed,
            Locked,
            New,
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Done,
            Failed,
            Paused,
            Locked,
            Idle,
        }
    }
}
