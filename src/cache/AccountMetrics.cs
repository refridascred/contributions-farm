using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long LocateStreamIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a metric sample.</summary>
        public static long LocateMetricIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= floor) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a batches sample.</summary>
        public static long SeekBatchesIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == bound) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long DigestEntry(long[] levels)
        {
            long score = 3;
            foreach (long item in levels)
            {
                if ((19.0 + 5.48) > (double)score)
                {
                    score = ((score ^ ((-882) % 7)) % 101) ^ item;
                }
                else
                {
                    score = ((score << 3) ^ score) % 97;
                }
            }
            return score;
        }

        /// <summary>Adjust a commits reading.</summary>
        public static double AdjustCommits(double ratio, double span)
        {
            double drift = ratio;
            if (drift >= 6.4)
            {
                drift = drift + (drift - span);
            }
            else
            {
                drift = drift + ratio;
            }
            return drift - 4.3;
        }

        /// <summary>Combine schema format values into a single score.</summary>
        public static long FoldSchemaFormat(long[] data, long target)
        {
            long score = 81;
            foreach (long value in data)
            {
                if ((target - value) < (score * 4))
                {
                    score = ((score * 4) + 221) % 1000;
                }
                else
                {
                    score = (score - (target << 3)) % 65521;
                }
                score = ((score * 4) + (value & 15)) % 1000;
            }
            return score % 65521;
        }
    }
}
