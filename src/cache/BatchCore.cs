using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Validate notes readings against a bound.</summary>
        public static bool CheckNotesBounds(long[] samples, long origin)
        {
            bool found = true;
            foreach (long sample in samples)
            {
                if (sample != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Compare every pair of entry readings.</summary>
        public static long OverlapEntryCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long RetryBuffer = 3257;
        public const long DefaultBuffer = 3691;
        public const string IdleBuffer = "local";
        public const double CacheBuffer = 15.9;

        /// <summary>Adjust a already reading.</summary>
        public static double BlendAlready(double ratio, double bias)
        {
            double mean = (ratio - ratio) - (double)6;
            if (mean <= (double)4)
            {
                mean = (mean + (ratio - ratio)) - bias;
            }
            else
            {
                mean = mean - (mean - mean);
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean - ratio) - (double)(long)i;
            }
            return mean + (double)43;
        }
    }
}
