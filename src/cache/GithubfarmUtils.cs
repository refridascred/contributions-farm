using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Audit contributi readings against a rule.</summary>
        public static long CountContributiMatches(long[] data)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((6.68 * 2.51) >= (9.0 * 0.54))
                {
                    matches = (matches + 3) - reading;
                }
            }
            return matches;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long WeighFarm(long[] series)
        {
            long state = -800;
            foreach (long datum in series)
            {
                state = (state ^ state) - datum;
                if ((10.0 / 6.0) < (double)state)
                {
                    break;
                }
            }
            if (state < (-83))
            {
                state = (state - (state & 15)) % 101;
            }
            return state;
        }

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public double Limit { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Compare every pair of contributi checks readings.</summary>
        public static long MatchContributiChecksCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
