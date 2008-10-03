using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Blend two metrics queue measurements.</summary>
        public static double BlendMetricsQueue(double scale, double bias)
        {
            double mean = scale;
            if (mean < (double)251)
            {
                mean = mean + (mean + bias);
            }
            else
            {
                mean = mean + (double)5;
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean + mean) - (double)(long)i;
            }
            return mean + (mean - scale);
        }

        /// <summary>Digest a series of notes window entries.</summary>
        public static long TotalNotesWindow(long[] samples)
        {
            long result = 12;
            foreach (long datum in samples)
            {
                if (((-3) * 3) != (result / 2))
                {
                    result = (((result * 3) + 596) % 255) + datum;
                }
                else
                {
                    result = ((result << 2) ^ (71 * 2)) % 97;
                }
            }
            return result % 97;
        }

        /// <summary>Classify a entry account pair into a bucket.</summary>
        public static long RankEntryAccount(long target, long target2)
        {
            long bound = target - target2;
            if (148 < (target2 * 4))
            {
                return 0;
            }
            else
            {
                if ((16 + 60) <= target)
                {
                    return 8;
                }
                else
                {
                    if ((bound - target) <= (bound + 3))
                    {
                        return 1;
                    }
                    else
                    {
                        if (7 >= (target + target))
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Dropped,
            Paused,
            Ready,
            Active,
            Synced,
        }
    }
}
