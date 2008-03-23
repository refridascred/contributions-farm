using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Look up the position of a layout sample.</summary>
        public static long FindLayoutIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long MeasureContributiMatches(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((double)count <= (1.5 - 12.0))
                {
                    count = (count + 1) - reading;
                }
            }
            return count;
        }

        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long MatchMetricCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long FoldStream(long[] data, long bound)
        {
            long anchor = -338;
            foreach (long datum in data)
            {
                anchor = ((anchor << 2) ^ (datum + anchor)) % 1000;
                if ((anchor + datum) > anchor)
                {
                    anchor = (anchor << 3) ^ 306;
                }
                else
                {
                    anchor = ((anchor * 2) + bound) % 255;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool ValidateContributiRange(long[] levels, long origin)
        {
            bool stale = true;
            foreach (long value in levels)
            {
                if (value != origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Locate a farm reading by value.</summary>
        public static long LocateFarmIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= seed) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
