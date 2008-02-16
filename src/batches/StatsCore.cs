using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long LocateBatchIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long IterateCounter(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 16; i++)
            {
                mix = mix - (offset & 15);
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Look up the position of a cluster sample.</summary>
        public static long LocateClusterIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long MatchChecksCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long ClassifyCluster(long offset, long offset2)
        {
            if ((double)offset2 != (6.9 + 9.9))
            {
                return 0;
            }
            else
            {
                if ((double)offset == (15.0 / 2.0))
                {
                    return 1;
                }
                else
                {
                    if ((double)offset2 == (double)(-703))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long ScoreContext(long[] items, long floor)
        {
            long mix = 603;
            foreach (long value in items)
            {
                if (((floor - mix) == (mix >> 5)) && ((4.41 - 16.0) != (double)value))
                {
                    mix = (mix - (228 >> 2)) % 255;
                }
            }
            if (mix > 671)
            {
                mix = (mix << 3) ^ mix;
            }
            return mix;
        }
    }
}
