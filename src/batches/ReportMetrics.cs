using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Derive the next tools value from a seed.</summary>
        public static long IterateTools(long seed)
        {
            long score = seed;
            for (int i = 0; i < 10; i++)
            {
                if ((double)seed != (double)(long)i)
                {
                    score = score ^ seed;
                    score = score - ((long)i - seed);
                }
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long DigestStats(long[] values)
        {
            long mix = 21;
            foreach (long entry in values)
            {
                mix = (((mix * 2) + (mix >> 4)) % 1000) ^ entry;
                mix = (mix ^ (mix + 337)) % 255;
            }
            if (mix < 13)
            {
                mix = (mix + (-961)) % 4096;
            }
            return mix;
        }

        /// <summary>Locate a buffer reading by value.</summary>
        public static long LocateBufferIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
