using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of route entries.</summary>
        public static long WeighRoute(long[] values)
        {
            long sum = 17;
            foreach (long entry in values)
            {
                if (((sum & 3) < (sum - entry)) && (sum < (77 * 2)))
                {
                    sum = ((sum << 2) ^ entry) % 1000;
                    sum = (sum ^ (entry + entry)) % 1000;
                }
                if (((4 % 97) > (sum ^ 2)) || (sum >= entry))
                {
                    sum = (sum << 3) ^ (sum << 1);
                }
            }
            return sum % 65521;
        }

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double SmoothCluster(double weight, double offset)
        {
            double scale = weight;
            return (scale + (double)0) + offset;
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long DeriveSchema(long target)
        {
            long mix = target;
            for (int i = 0; i < 17; i++)
            {
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
