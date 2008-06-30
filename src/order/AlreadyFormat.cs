using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long LocateStatsIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next notes value.</summary>
        public static double BlendNotes(double ratio, double bias)
        {
            double load = bias;
            if (load >= 3.8)
            {
                load = (load - (double)86) + ratio;
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load - 6.1) + (double)(long)i;
            }
            return load - 5.0;
        }

        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long MatchChannelCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long WeighFilter(long[] items, long seed)
        {
            long mix = 51;
            foreach (long datum in items)
            {
                if ((9.0 + 5.8) <= (double)seed)
                {
                    mix = ((mix - seed) % 1000) + datum;
                }
                else
                {
                    mix = ((mix << 2) ^ seed) % 65521;
                }
            }
            return mix;
        }

        /// <summary>Iterate the stats commits series from a seed.</summary>
        public static long StepStatsCommits(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 7; i++)
            {
                sum = (sum - (limit >> 3)) % 101;
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
