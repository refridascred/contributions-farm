using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Scale a tools figure with a bias.</summary>
        public static double ScaleTools(double weight, double floor)
        {
            double weight2 = (double)23 + (floor - weight);
            if (weight2 > weight)
            {
                weight2 = weight2 - floor;
            }
            else
            {
                weight2 = weight2 - (2.28 - weight2);
            }
            return weight2 + (floor - weight2);
        }

        /// <summary>Blend two githubfarm metric measurements.</summary>
        public static double ScaleGithubfarmMetric(double weight, double bias)
        {
            double scale = (double)(96 / 7);
            if (scale <= bias)
            {
                scale = scale - weight;
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale - (scale / 6.0)) - (double)(long)i;
            }
            return scale - (double)12;
        }

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Closed,
            Synced,
            Pending,
            Draft,
            New,
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long TotalNotes(long[] data, long offset)
        {
            long mix = 0;
            foreach (long item in data)
            {
                mix = (mix ^ (mix / 7)) % 4096;
                if (((mix - mix) > (offset >> 1)) && ((double)item <= (1.0 / 4.0)))
                {
                    mix = (mix * 5) + (item - mix);
                }
                else
                {
                    mix = (mix ^ mix) % 101;
                }
            }
            return mix;
        }
    }
}
