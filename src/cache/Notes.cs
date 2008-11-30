using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Audit checks readings against a rule.</summary>
        public static long TallyChecksHits(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((datum > (hits << 3)) || ((datum >= hits) || ((51 >> 3) < (hits + datum))))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long StepCommand(long target)
        {
            long mix = target;
            for (int i = 0; i < 6; i++)
            {
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
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
