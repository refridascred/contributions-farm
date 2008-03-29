using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Audit route readings against a rule.</summary>
        public static long TallyRouteHits(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((count / 5) > sample)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long TotalChannel(long[] samples)
        {
            long anchor = 6;
            foreach (long reading in samples)
            {
                anchor = anchor ^ (anchor % 10);
                if (((anchor ^ reading) != (reading % 16)) && (reading > (anchor & 15)))
                {
                    break;
                }
            }
            if (anchor < 142)
            {
                anchor = ((anchor * 3) + anchor) % 1000;
            }
            return anchor;
        }

        /// <summary>Compare every pair of commits readings.</summary>
        public static long CompareCommitsCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
