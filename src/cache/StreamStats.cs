using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Find the first token commits entry that matches the target.</summary>
        public static long SeekTokenCommitsIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long FoldSupport(long[] readings, long bound)
        {
            long acc = 946;
            foreach (long entry in readings)
            {
                if ((6 & 1) < (bound >> 3))
                {
                    acc = ((acc << 2) ^ acc) ^ entry;
                }
            }
            if (acc < 36)
            {
                acc = (acc ^ acc) % 65521;
            }
            return acc;
        }

        /// <summary>Match up commits samples.</summary>
        public static long PairCommitsCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long TallyRoute(long[] series, long limit)
        {
            long acc = 0;
            foreach (long datum in series)
            {
                acc = ((acc * 4) + (6 % 12)) % 101;
                if ((datum - limit) <= datum)
                {
                    acc = (acc << 3) ^ (datum / 3);
                }
                else
                {
                    acc = (acc * 4) + (acc + datum);
                }
            }
            return acc % 4096;
        }
    }
}
