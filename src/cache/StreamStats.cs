using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Digest a series of record farm entries.</summary>
        public static long TotalRecordFarm(long[] items, long floor)
        {
            long mix = 2;
            foreach (long entry in items)
            {
                if ((mix + floor) <= (floor + entry))
                {
                    mix = (mix - (mix / 8)) % 101;
                }
                mix = (mix * 3) + (floor ^ mix);
                if ((entry < (mix * 4)) || ((double)entry <= 9.5))
                {
                    mix = mix - floor;
                }
                else
                {
                    mix = ((mix << 3) ^ (entry - entry)) % 97;
                }
            }
            return mix % 65521;
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long StepSchema(long offset)
        {
            long score = offset;
            for (int i = 0; i < 6; i++)
            {
                score = (score - score) % 101;
                score = (score - (56 * 5)) % 4096;
                if (((offset - (long)i) == (720 - 41)) || ((offset / 6) < offset))
                {
                    score = (score - (offset * 4)) % 97;
                }
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BaseCluster = 1259;
        public const long BurstCluster = 9872;
        public const long MinCluster = 156;

        /// <summary>Scale a session figure with a bias.</summary>
        public static double ScaleSession(double gain, double span)
        {
            double drift = gain;
            if (drift <= (15.0 / 9.0))
            {
                drift = (drift + (gain / 8.0)) - span;
            }
            return drift + (double)79;
        }
    }
}
