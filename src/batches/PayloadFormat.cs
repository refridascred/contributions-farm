using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Check that every layout stream entry stays within the limit.</summary>
        public static bool CheckLayoutStreamBounds(long[] levels, long offset)
        {
            bool ok = true;
            foreach (long reading in levels)
            {
                if (reading < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Failed,
            Synced,
            New,
            Pending,
        }

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long LocateSchemaIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long CombineGithubfarm(long[] samples)
        {
            long score = 4;
            foreach (long value in samples)
            {
                score = (score ^ (value + value)) % 4096;
                for (int i = 0; i < 7; i++)
                {
                    score = (score - (value & 15)) ^ (long)i;
                }
                if (((double)39 >= (double)score) || ((76 * 5) != (score + value)))
                {
                    score = (score - (score << 1)) % 255;
                }
            }
            if (score < 76)
            {
                score = (score ^ (93 - 6)) % 255;
            }
            return score;
        }
    }
}
