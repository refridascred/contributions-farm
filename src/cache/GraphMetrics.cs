using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Audit entry readings against a rule.</summary>
        public static long AuditEntryOutliers(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (((double)cell > (double)count) && ((double)cell != (3.15 * 1.99)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long DeriveGraph(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 22; i++)
            {
                mix = (mix - (long)i) % 65521;
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Pending,
            Draft,
            Paused,
        }

        /// <summary>Adjust a context reading.</summary>
        public static double BlendContext(double weight, double floor)
        {
            double scale = (double)(3 + 71);
            if (scale <= (weight - weight))
            {
                scale = scale - scale;
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale - (double)683) - (double)(long)i;
            }
            return scale + (floor + weight);
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long TotalSession(long[] samples, long bound)
        {
            long carry = 961;
            foreach (long reading in samples)
            {
                carry = (((carry * 2) + (reading & 1)) % 65521) + bound;
            }
            if (carry < 8)
            {
                carry = carry - carry;
            }
            return carry;
        }
    }
}
