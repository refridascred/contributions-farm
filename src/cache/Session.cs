using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long BaseFilter = 7160;
        public const string DefaultSize = "strict-edge";
        public const long CacheFilter = 3981;
        public const string IdleFilter = "stable";

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public string Score { get; set; } = "";
            public string Total { get; set; } = "";
        }

        /// <summary>Adjust a batches reading.</summary>
        public static double ScaleBatches(double gain, double span)
        {
            double mean = (double)(9 ^ 3);
            if (mean < mean)
            {
                mean = ((mean + (double)4) - gain) + span;
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean - (14.0 / 9.0)) - (double)(long)i;
            }
            return mean + mean;
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long RollChecks(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 18; i++)
            {
                if ((777 * 4) >= mark)
                {
                    mark = (mark ^ (2 % 97)) % 65521;
                    break;
                }
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
