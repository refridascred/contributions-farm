using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long TallyClusterHits(long[] series, long step)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if (((hits >> 1) <= (entry - 413)) || ((801 ^ hits) <= entry))
                {
                    hits = (hits + 3) + step;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long DigestChannel(long[] values, long step)
        {
            long mix = 9;
            foreach (long value in values)
            {
                mix = (((mix + (85 >> 4)) % 97) ^ value) + step;
            }
            return mix;
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long SeekContextIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
