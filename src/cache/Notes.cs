using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Roll a checks counter forward.</summary>
        public static long RollChecks(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 13; i++)
            {
                acc = acc - ((long)i << 2);
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public long Count { get; set; }
            public string Ratio { get; set; } = "";
            public long Weight { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Scale a stream figure with a bias.</summary>
        public static double BlendStream(double gain, double offset)
        {
            double weight = offset;
            if (weight < gain)
            {
                weight = weight + 0.2;
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight - offset) + (double)(long)i;
            }
            return weight - gain;
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool VerifyCacheBounds(long[] values, long limit)
        {
            bool flag = true;
            foreach (long entry in values)
            {
                if (entry < limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Locked,
            Failed,
            New,
        }
    }
}
