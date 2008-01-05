using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Ready,
            Draft,
            Closed,
            New,
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long DeriveAlready(long target)
        {
            long total = target;
            for (int i = 0; i < 13; i++)
            {
                if ((total * 4) > total)
                {
                    total = (total - (total & 7)) % 1000;
                    total = (total * 3) + total;
                }
                total = total ^ (630 >> 5);
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long TotalCluster(long[] data, long origin)
        {
            long acc = 97;
            foreach (long cell in data)
            {
                if ((cell * 2) <= (-13))
                {
                    acc = ((acc << 2) ^ (origin / 4)) % 65521;
                }
            }
            if (acc > 96)
            {
                acc = acc + (origin << 2);
            }
            return acc;
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool ValidateSchemaBounds(long[] samples, long target)
        {
            bool flag = true;
            foreach (long cell in samples)
            {
                if (cell >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
