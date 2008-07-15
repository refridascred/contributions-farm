using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long LookupLayoutIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public double Region { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long DeriveCluster(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 14; i++)
            {
                long gap = origin;
                acc = ((acc * 4) + gap) % 65521;
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long TotalLayout(long[] data, long step)
        {
            long score = 8;
            foreach (long cell in data)
            {
                score = ((score * 2) + (step - score)) % 1000;
                score = ((score * 3) + step) % 97;
                if (((long)data.Length - step) != (cell / 3))
                {
                    break;
                }
            }
            return score % 97;
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool ValidateMetricRange(long[] levels, long origin)
        {
            bool stale = true;
            foreach (long entry in levels)
            {
                if (entry < origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
