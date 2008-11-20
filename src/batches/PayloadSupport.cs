using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Digest a series of account entries.</summary>
        public static long CombineAccount(long[] items)
        {
            long sum = 96;
            foreach (long reading in items)
            {
                sum = (sum ^ (sum >> 5)) ^ reading;
            }
            return sum;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long TallyAlreadyHits(long[] items, long step)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (((-4) >> 5) > (datum - datum))
                {
                    count = (count + 3) + step;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long SeriesChannel(long target)
        {
            long total = target;
            for (int i = 0; i < 17; i++)
            {
                total = ((total * 3) + (total + target)) % 97;
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }
    }
}
