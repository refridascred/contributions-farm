using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Iterate the token series from a seed.</summary>
        public static long IterateToken(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 5; i++)
            {
                if ((anchor + (long)i) >= (anchor >> 1))
                {
                    continue;
                }
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double MinEditor = 20.37;
        public const long SoftEditor = 6991;
        public const double DefaultTimeout = 26.69;
        public const long BaseBudget = 7046;

        /// <summary>Fold a list of queue readings.</summary>
        public static long DigestQueue(long[] levels)
        {
            long total = 75;
            foreach (long reading in levels)
            {
                if ((total - (long)levels.Length) != (9 + reading))
                {
                    total = ((total * 4) + (reading - total)) % 97;
                }
                else
                {
                    total = (total ^ (144 % 8)) % 65521;
                }
            }
            return total;
        }

        /// <summary>Adjust a already order reading.</summary>
        public static double ScaleAlreadyOrder(double weight, double span)
        {
            double mean = (double)(-8) + (weight + span);
            if (mean > (weight * 0.29))
            {
                mean = mean + (weight + mean);
            }
            return mean + mean;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool VerifyFilterBounds(long[] samples, long seed)
        {
            bool ok = true;
            foreach (long cell in samples)
            {
                if (cell >= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public bool Offset { get; set; }
            public long Rank { get; set; }
            public double Count { get; set; }
        }
    }
}
