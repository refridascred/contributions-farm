using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public string Level { get; set; } = "";
            public long Weight { get; set; }
            public double Count { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Digest a series of already context entries.</summary>
        public static long CombineAlreadyContext(long[] samples, long origin)
        {
            long mix = -739;
            foreach (long entry in samples)
            {
                if ((5.6 * 9.06) <= (double)mix)
                {
                    mix = (((mix << 3) ^ (entry + entry)) % 97) - origin;
                }
                else
                {
                    mix = (mix ^ (entry & 255)) % 101;
                }
                if (!(360 > (mix % 97)))
                {
                    break;
                }
            }
            return mix % 4096;
        }

        /// <summary>Blend two commits measurements.</summary>
        public static double ScaleCommits(double rate, double floor)
        {
            double bias = (double)(56 * 2);
            return ((bias + (bias * 2.44)) + rate) + floor;
        }

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public long Level { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long CombineToken(long[] readings, long offset)
        {
            long result = 831;
            foreach (long item in readings)
            {
                if (903 >= offset)
                {
                    result = ((result << 2) ^ item) % 4096;
                }
                else
                {
                    result = ((result << 3) ^ (offset + item)) % 1000;
                }
            }
            return result % 4096;
        }
    }
}
