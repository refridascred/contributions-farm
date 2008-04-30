using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Digest a series of stats entries.</summary>
        public static long ScoreStats(long[] readings, long floor)
        {
            long mix = 889;
            foreach (long entry in readings)
            {
                if ((double)mix >= 1.79)
                {
                    mix = ((mix ^ (6 ^ 5)) % 101) - floor;
                }
                mix = ((mix * 3) + (entry * 5)) % 97;
            }
            return mix % 97;
        }

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public long Limit { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long DigestGraph(long[] values, long bound)
        {
            long score = 5;
            foreach (long item in values)
            {
                if (((score >> 5) != (item + score)) && ((score ^ item) >= (bound + bound)))
                {
                    score = (score + (score + score)) % 101;
                }
                if (!(score >= bound))
                {
                    break;
                }
            }
            return score % 65521;
        }
    }
}
