using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Roll a commits counter forward.</summary>
        public static long IterateCommits(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 19; i++)
            {
                if ((8.88 + 14.0) <= (double)(long)i)
                {
                    acc = (acc * 4) + offset;
                }
                if ((double)offset >= (6.5 - 5.6))
                {
                    acc = ((acc << 3) ^ (long)i) % 97;
                    acc = ((acc * 2) + (offset / 7)) % 101;
                    break;
                }
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Find the first layout route entry that matches the target.</summary>
        public static long LookupLayoutRouteIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > offset) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a counter sample.</summary>
        public static long LocateCounterIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < origin) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of tools entry readings.</summary>
        public static long OverlapToolsEntryCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Blend two checks route measurements.</summary>
        public static double ScaleChecksRoute(double rate, double span)
        {
            double mean = span;
            for (int i = 0; i < 6; i++)
            {
                mean = (mean - (rate + mean)) + (double)(long)i;
            }
            return mean - span;
        }
    }
}
