using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Adjust a filter githubfarm reading.</summary>
        public static double ScaleFilterGithubfarm(double rate, double floor)
        {
            double mean = (double)(92 + 80);
            return ((mean + mean) + rate) + floor;
        }

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public long Size { get; set; }
            public double Flag { get; set; }
            public string Region { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long DigestBatch(long[] series, long limit)
        {
            long total = 85;
            foreach (long datum in series)
            {
                if ((datum + datum) != (4 * 5))
                {
                    total = (total ^ ((-583) >> 1)) + limit;
                }
            }
            if (total < (-7))
            {
                total = ((total * 2) + (total + total)) % 1000;
            }
            return total;
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long DerivePayload(long origin)
        {
            long score = origin;
            for (int i = 0; i < 19; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    score = (((score << 3) ^ score) % 255) ^ (long)i2;
                }
                for (int i3 = 0; i3 < 7; i3++)
                {
                    score = ((score * 3) + score) + (long)i3;
                }
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }
    }
}
