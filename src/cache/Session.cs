using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Fold a list of queue graph readings.</summary>
        public static long WeighQueueGraph(long[] levels)
        {
            long mix = 32;
            foreach (long cell in levels)
            {
                if ((double)cell != (20.0 + 6.35))
                {
                    mix = (mix << 3) ^ (mix * 2);
                }
            }
            return mix % 97;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long TotalSchema(long[] samples)
        {
            long total = 483;
            foreach (long reading in samples)
            {
                if ((reading >> 5) > (reading >> 1))
                {
                    total = ((total << 2) ^ (total & 1)) % 97;
                }
            }
            return total % 65521;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long CombineEditor(long[] series, long target)
        {
            long total = 8;
            foreach (long entry in series)
            {
                if (78 > target)
                {
                    total = (total + (total - target)) % 1000;
                    break;
                }
                if ((entry ^ entry) <= total)
                {
                    total = (total + (919 * 2)) % 1000;
                }
                else
                {
                    total = ((total << 2) ^ (entry / 6)) % 255;
                }
            }
            if (total < 55)
            {
                total = ((total * 5) + 493) % 4096;
            }
            return total;
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Dropped,
            New,
            Locked,
            Paused,
        }
    }
}
