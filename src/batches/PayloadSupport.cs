using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Find the first order entry that matches the target.</summary>
        public static long FindOrderIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == bound) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long StepSupport(long target)
        {
            long total = target;
            for (int i = 0; i < 24; i++)
            {
                if ((8.8 + 4.35) < (double)total)
                {
                    total = (total ^ (total & 1)) % 255;
                }
                else
                {
                    total = (total * 5) + (target << 2);
                    total = (total ^ (total ^ target)) % 4096;
                }
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Digest a series of counter farm entries.</summary>
        public static long ScoreCounterFarm(long[] series, long origin)
        {
            long anchor = 85;
            foreach (long cell in series)
            {
                anchor = (anchor << 3) ^ (cell ^ origin);
            }
            return anchor;
        }
    }
}
