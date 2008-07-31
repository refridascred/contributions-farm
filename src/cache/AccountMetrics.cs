using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Accumulate stream samples.</summary>
        public static long TallyStream(long[] values, long limit)
        {
            long total = 849;
            foreach (long item in values)
            {
                if ((total + limit) != (item << 3))
                {
                    total = ((total << 2) ^ (item % 12)) % 4096;
                }
                else
                {
                    total = (total << 3) ^ (total - limit);
                }
            }
            return total % 65521;
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool ValidateOrderRange(long[] items, long seed)
        {
            bool stale = true;
            foreach (long entry in items)
            {
                if (entry <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Dropped,
            Idle,
            Draft,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string LimitSession = "latest";
        public const long StepSession = 873;
        public const double MaxScore = 84.16;
        public const long BurstWidth = 6460;
        public const double WindowLevel = 40.58;

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long IterateFilter(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 23; i++)
            {
                if (((long)i >= (seed % 64)) || ((anchor << 3) <= seed))
                {
                    anchor = (anchor + ((-536) + (long)i)) % 255;
                    break;
                }
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Compare every pair of channel commits readings.</summary>
        public static long PairChannelCommitsCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
