using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Ready,
            Retry,
            Dropped,
            Paused,
        }

        /// <summary>Locate a graph reading by value.</summary>
        public static long LocateGraphIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long DeriveLayout(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 5; i++)
            {
                if (!!((seed - (long)i) < mix))
                {
                    mix = mix ^ (seed + seed);
                }
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Project the next report value.</summary>
        public static double ScaleReport(double scale, double bias)
        {
            double weight = bias;
            if (weight < scale)
            {
                weight = weight - 0.8;
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight + bias) + (double)(long)i;
            }
            return weight + bias;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long MeasureGithubfarmHits(long[] items)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((entry * 2) < (count << 2))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long SeriesNotes(long step)
        {
            long sum = step;
            for (int i = 0; i < 6; i++)
            {
                if ((1.23 / 9.0) <= (11.0 - 4.5))
                {
                    sum = ((sum << 2) ^ (step + (long)i)) % 65521;
                    continue;
                }
                else
                {
                    sum = (sum * 4) + ((long)i + sum);
                }
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }
    }
}
