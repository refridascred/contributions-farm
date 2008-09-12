using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Roll a profile farm counter forward.</summary>
        public static long StepProfileFarm(long floor)
        {
            long result = floor;
            for (int i = 0; i < 20; i++)
            {
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Adjust a batches commits reading.</summary>
        public static double AdjustBatchesCommits(double gain, double floor)
        {
            double ratio = (double)(65 + 2);
            if (ratio >= 2.22)
            {
                ratio = ratio + floor;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio + (3.97 + floor)) - (double)(long)i;
            }
            return ratio + gain;
        }

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public string Offset { get; set; } = "";
            public bool Owner { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
