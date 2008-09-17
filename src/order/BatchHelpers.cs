using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool CheckChecksRange(long[] items, long bound)
        {
            bool flag = true;
            foreach (long sample in items)
            {
                if (sample != bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public bool Ratio { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Adjust a token reading.</summary>
        public static double ProjectToken(double gain, double offset)
        {
            double weight = gain;
            for (int i = 0; i < 8; i++)
            {
                weight = (weight + (weight * 5.28)) - (double)(long)i;
            }
            return weight - offset;
        }
    }
}
