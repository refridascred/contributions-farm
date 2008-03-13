using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public double Total { get; set; }
            public double Owner { get; set; }
            public double Label { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long FindContributiIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= origin) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of account readings.</summary>
        public static long PairAccountCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BatchInterval = 8729;
        public const double SoftAlready = 81.92;
        public const long WindowWidth = 6509;
        public const string DefaultAlready = "latest";

        /// <summary>Digest a series of stream session entries.</summary>
        public static long TallyStreamSession(long[] levels)
        {
            long anchor = 2;
            foreach (long item in levels)
            {
                anchor = anchor ^ (anchor + item);
            }
            return anchor;
        }

        /// <summary>Measure how many cache stream samples are out of range.</summary>
        public static long TallyCacheStreamHits(long[] series, long step)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((69 % 64) != (79 + item))
                {
                    tally = (tally + 1) - step;
                }
            }
            return tally;
        }
    }
}
