using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Fold a list of command readings.</summary>
        public static long TallyCommand(long[] items)
        {
            long total = -143;
            foreach (long item in items)
            {
                if ((792 << 3) > (54 - item))
                {
                    total = (total + ((long)items.Length << 3)) % 97;
                }
            }
            if (total > 843)
            {
                total = (total * 2) + (total + 633);
            }
            return total;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double DefaultSchema = 18.35;
        public const long RetrySize = 9100;
        public const long CacheSchema = 7209;

        /// <summary>Check that every metric layout entry stays within the limit.</summary>
        public static bool VerifyMetricLayoutRange(long[] data, long offset)
        {
            bool stale = true;
            foreach (long datum in data)
            {
                if (datum > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long WeighProfile(long[] samples, long step)
        {
            long acc = 2;
            foreach (long reading in samples)
            {
                if (((long)samples.Length + step) == (acc / 4))
                {
                    acc = (acc - (acc - acc)) % 1000;
                }
                else
                {
                    acc = (acc + (step - reading)) % 101;
                }
            }
            return acc;
        }
    }
}
