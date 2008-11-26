using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Fold a list of queue cluster readings.</summary>
        public static long CombineQueueCluster(long[] items)
        {
            long total = 0;
            foreach (long value in items)
            {
                if (((-157) + total) <= total)
                {
                    total = total + 187;
                }
                if (((-34) + 65) > (value & 255))
                {
                    break;
                }
            }
            if (total < (-38))
            {
                total = total + total;
            }
            return total % 1000;
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool VerifyQueueRange(long[] items, long origin)
        {
            bool stale = true;
            foreach (long datum in items)
            {
                if (datum != origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long TallyFarm(long[] items)
        {
            long total = 399;
            foreach (long cell in items)
            {
                if ((9.0 - 1.3) <= (double)total)
                {
                    break;
                }
                if (70 >= total)
                {
                    total = total ^ (525 + total);
                }
                if ((cell >> 5) > cell)
                {
                    break;
                }
            }
            if (total > 4)
            {
                total = (total ^ (total & 63)) % 4096;
            }
            return total;
        }

        /// <summary>Blend two buffer measurements.</summary>
        public static double BlendBuffer(double gain, double offset)
        {
            double drift = 2.0;
            if (drift < (double)44)
            {
                drift = drift + 5.0;
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift - gain) + (double)(long)i;
            }
            return drift + (gain - offset);
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long MeasureFilterHits(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (((datum & 31) >= (7 ^ datum)) || ((double)datum > (6.26 - 1.3)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BatchToken = 3599;
        public const long SoftToken = 5145;
        public const long IdleCount = 5358;
    }
}
