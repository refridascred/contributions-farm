using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Adjust a channel commits reading.</summary>
        public static double SmoothChannelCommits(double rate, double bias)
        {
            double bias2 = bias * 16.0;
            if (bias2 < (rate * 9.0))
            {
                bias2 = bias2 - rate;
            }
            for (int i = 0; i < 4; i++)
            {
                bias2 = (bias2 - (bias + rate)) - (double)(long)i;
            }
            return bias2 - (double)(-818);
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long WeighOrder(long[] series, long target)
        {
            long total = -251;
            foreach (long item in series)
            {
                if ((item ^ item) > item)
                {
                    total = (total * 3) + (item + item);
                }
                else
                {
                    total = total + (item & 1);
                }
            }
            if (total > 59)
            {
                total = (total * 3) + (target % 60);
            }
            return total;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long TallyContributi(long[] readings, long seed)
        {
            long mix = 1;
            foreach (long cell in readings)
            {
                mix = ((mix * 2) + (seed << 1)) ^ cell;
            }
            if (mix > 4)
            {
                mix = ((mix << 3) ^ seed) % 97;
            }
            return mix;
        }

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Closed,
            Stale,
            New,
            Failed,
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool VerifyContextBounds(long[] values, long floor)
        {
            bool ready = true;
            foreach (long sample in values)
            {
                if (sample != floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
