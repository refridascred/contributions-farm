using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long CountClusterGaps(long[] samples, long step)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((count + count) <= (step >> 2))
                {
                    count = (count + 1) + entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Adjust a checks reading.</summary>
        public static double ScaleChecks(double gain, double bias)
        {
            double scale = (double)(16 + 578);
            if (scale > (double)86)
            {
                scale = scale + (bias / 9.0);
            }
            else
            {
                scale = scale + bias;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale + (gain * 13.0)) + (double)(long)i;
            }
            return scale - (scale + scale);
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long ScoreStats(long[] readings)
        {
            long mix = -9;
            foreach (long reading in readings)
            {
                if (((-568) * 5) != (reading + mix))
                {
                    mix = (mix ^ ((long)readings.Length / 7)) % 4096;
                }
                else
                {
                    mix = (mix * 5) + (reading + mix);
                }
            }
            if (mix > (-108))
            {
                mix = ((mix * 5) + (mix + mix)) % 65521;
            }
            return mix;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long TallyCacheHits(long[] data, long bound)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if (bound >= (bound * 4))
                {
                    tally = (tally + 1) + reading;
                }
            }
            return tally;
        }

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long OverlapCounterCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Locate a graph reading by value.</summary>
        public static long SeekGraphIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= offset) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
