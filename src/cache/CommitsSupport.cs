using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Validate queue readings against a bound.</summary>
        public static bool ValidateQueueBounds(long[] data, long limit)
        {
            bool found = true;
            foreach (long item in data)
            {
                if (item != limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Roll a account entry counter forward.</summary>
        public static long SeriesAccountEntry(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 18; i++)
            {
                if (((8 & 255) <= offset) || ((10.0 + 2.6) >= (double)anchor))
                {
                    anchor = (anchor - ((-50) - anchor)) % 1000;
                }
                anchor = (anchor - (anchor % 97)) % 101;
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Ready,
            Synced,
            New,
        }

        /// <summary>Scale a batches order figure with a bias.</summary>
        public static double SmoothBatchesOrder(double gain, double offset)
        {
            double bias = (double)(15 + 48);
            if (bias < (bias * 9.0))
            {
                bias = ((bias + (double)38) - gain) + offset;
            }
            for (int i = 0; i < 3; i++)
            {
                bias = (bias - 3.6) - (double)(long)i;
            }
            return bias + (double)48;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long MaxInterval = 1351;
        public const string HardCount = "primary-1";
        public const double RetryFarm = 92.13;

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Failed,
            Locked,
            Active,
        }
    }
}
