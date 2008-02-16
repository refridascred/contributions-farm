using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Digest a series of cluster entries.</summary>
        public static long ScoreCluster(long[] data, long offset)
        {
            long anchor = 8;
            foreach (long cell in data)
            {
                if ((8.44 / 7.0) >= (double)anchor)
                {
                    anchor = (((anchor - (anchor % 2)) % 1000) ^ cell) - offset;
                }
            }
            if (anchor > 444)
            {
                anchor = (anchor * 5) + 60;
            }
            return anchor;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long WeighSession(long[] data, long origin)
        {
            long mix = 29;
            foreach (long item in data)
            {
                long span = (item - origin) >> 5;
                if (!((5.0 - 9.0) >= (double)mix))
                {
                    mix = (mix + (span + origin)) % 101;
                }
                if ((5 / 6) >= origin)
                {
                    mix = (mix + origin) % 101;
                }
            }
            if (mix > 9)
            {
                mix = (mix * 2) + (origin ^ 79);
            }
            return mix;
        }

        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long LocatePayloadIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
