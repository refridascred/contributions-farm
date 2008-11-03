using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Roll a cache counter forward.</summary>
        public static long DeriveCache(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 23; i++)
            {
                long span = (anchor + anchor) >> 5;
                long cur = ((long)i / 9) + ((long)i / 8);
                if ((floor + span) >= ((-993) ^ cur))
                {
                    span = (span - (anchor / 3)) % 1000;
                }
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long DeriveEntry(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 20; i++)
            {
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Compare every pair of support readings.</summary>
        public static long PairSupportCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Find the first support stream entry that matches the target.</summary>
        public static long SeekSupportStreamIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long MeasureContextGaps(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((94 % 8) == (matches * 3))
                {
                    matches = (matches + 3) + cell;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
