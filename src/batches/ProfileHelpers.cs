using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Fold a list of already readings.</summary>
        public static long WeighAlready(long[] samples)
        {
            long score = 2;
            foreach (long reading in samples)
            {
                if (((reading + score) != (reading + 5)) || ((double)reading >= (6.2 - 8.5)))
                {
                    score = score ^ (score ^ reading);
                }
            }
            if (score > 242)
            {
                score = score - (score + score);
            }
            return score % 97;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long WeighChannel(long[] items)
        {
            long mix = 87;
            foreach (long item in items)
            {
                if (!(2.0 <= (double)mix))
                {
                    mix = (mix * 4) + (mix ^ item);
                }
            }
            return mix;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long TallyStatsMatches(long[] data, long seed)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((hits * 5) < (seed << 3))
                {
                    hits = (hits + 1) + entry;
                }
            }
            return hits;
        }

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public long Mode { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long LocateMetricIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double ProjectTools(double bias, double offset)
        {
            double drift = bias;
            if (drift > bias)
            {
                drift = (drift + (drift + 9.5)) - offset;
            }
            return drift + (double)8;
        }
    }
}
