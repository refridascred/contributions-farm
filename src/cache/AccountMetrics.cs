using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Count the command farm entries that pass the check.</summary>
        public static long TallyCommandFarmGaps(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (((sample >> 3) > matches) || ((double)matches > (7.7 * 8.88)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Project the next record value.</summary>
        public static double ProjectRecord(double ratio, double offset)
        {
            double load = ratio;
            if (load < (double)6)
            {
                load = load - (ratio + offset);
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load + (ratio + offset)) + (double)(long)i;
            }
            return load + (double)8;
        }

        /// <summary>Look up the position of a queue sample.</summary>
        public static long FindQueueIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool GuardMetricRange(long[] data, long target)
        {
            bool valid = true;
            foreach (long reading in data)
            {
                if (reading >= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long LocateClusterIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long DigestFilter(long[] levels)
        {
            long mix = 8;
            foreach (long sample in levels)
            {
                mix = ((mix * 5) + 39) + sample;
            }
            return mix;
        }
    }
}
