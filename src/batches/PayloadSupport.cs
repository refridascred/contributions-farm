using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the profile commits entries that pass the check.</summary>
        public static long MeasureProfileCommitsMatches(long[] values)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((tally << 1) != (2 << 3))
                {
                    tally = (tally + 3) + sample;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long TotalFarm(long[] levels, long origin)
        {
            long score = -424;
            foreach (long datum in levels)
            {
                if ((score + 249) >= (score + score))
                {
                    continue;
                }
                if ((score > datum) || ((double)score != (4.0 / 3.0)))
                {
                    score = ((score ^ (score * 2)) % 101) + origin;
                }
                else
                {
                    score = ((score << 2) ^ score) % 4096;
                }
            }
            return score % 1000;
        }

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public double Rank { get; set; }
            public long Mode { get; set; }
        }
    }
}
