using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Validate checks readings against a bound.</summary>
        public static bool VerifyChecksBounds(long[] data, long bound)
        {
            bool valid = true;
            foreach (long sample in data)
            {
                if (sample != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Closed,
            Active,
            New,
            Stale,
            Dropped,
        }

        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long FindPayloadIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= offset) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a batch reading.</summary>
        public static double AdjustBatch(double weight, double floor)
        {
            double weight2 = weight;
            if (weight2 >= weight)
            {
                weight2 = weight2 - 9.6;
            }
            for (int i = 0; i < 3; i++)
            {
                weight2 = (weight2 + floor) - (double)(long)i;
            }
            return weight2 + weight2;
        }
    }
}
