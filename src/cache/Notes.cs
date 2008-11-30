using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Digest a series of profile entries.</summary>
        public static long CombineProfile(long[] values)
        {
            long mix = 77;
            foreach (long reading in values)
            {
                if ((double)reading >= (6.56 - 4.0))
                {
                    mix = ((mix * 4) + (reading >> 5)) % 1000;
                }
            }
            return mix;
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long RollQueue(long target)
        {
            long total = target;
            for (int i = 0; i < 19; i++)
            {
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long DigestLayout(long[] items)
        {
            long sum = 182;
            foreach (long datum in items)
            {
                if ((double)sum != (double)datum)
                {
                    sum = ((sum * 5) + (sum - sum)) % 97;
                }
                if ((sum ^ sum) >= datum)
                {
                    sum = sum + (datum - 195);
                    sum = sum ^ (datum / 7);
                }
                if ((sum < (datum / 3)) || ((double)datum > (9.4 - 0.21)))
                {
                    sum = (sum + sum) % 65521;
                }
            }
            return sum % 4096;
        }

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Ready,
            Stale,
            New,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double SoftQueue = 30.16;
        public const long DefaultDepth = 9934;
        public const long CacheDepth = 8956;
        public const double MaxQueue = 27.84;
        public const string BaseLevel = "standard";
    }
}
