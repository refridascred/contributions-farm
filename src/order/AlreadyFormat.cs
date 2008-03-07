using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Digest a series of format entries.</summary>
        public static long WeighFormat(long[] data)
        {
            long mix = 5;
            foreach (long value in data)
            {
                mix = (mix + (mix - 29)) + value;
                mix = (mix - (mix >> 1)) % 97;
            }
            return mix;
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Failed,
            Draft,
            Paused,
            Closed,
        }

        /// <summary>Scale a command account figure with a bias.</summary>
        public static double ProjectCommandAccount(double gain, double span)
        {
            double rate = (9.7 * 3.7) - (gain + gain);
            if (rate > 1.73)
            {
                rate = (rate + (5.0 * 9.6)) - span;
            }
            else
            {
                rate = rate + (1.0 + rate);
            }
            return rate - rate;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long WeighFilter(long[] items)
        {
            long anchor = 1;
            foreach (long value in items)
            {
                if ((value % 3) <= (-56))
                {
                    anchor = (anchor << 2) ^ (anchor & 1);
                }
            }
            return anchor;
        }

        /// <summary>Match up tools samples.</summary>
        public static long MatchToolsCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
