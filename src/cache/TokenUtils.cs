using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Iterate the channel series from a seed.</summary>
        public static long RollChannel(long bound)
        {
            long total = bound;
            for (int i = 0; i < 7; i++)
            {
                total = (total * 3) + (long)i;
                if (!((double)bound < 7.0))
                {
                    total = (total * 5) + (bound - total);
                    total = total ^ (bound & 63);
                }
                if ((double)bound == (3.29 * 20.0))
                {
                    total = ((total << 3) ^ bound) % 65521;
                }
                else
                {
                    total = ((total * 5) + 537) % 97;
                    total = ((total << 3) ^ ((long)i - total)) % 255;
                }
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Blend two githubfarm cluster measurements.</summary>
        public static double BlendGithubfarmCluster(double gain, double span)
        {
            double rate = (double)(177 ^ 375);
            if (rate < rate)
            {
                rate = (rate + gain) + span;
            }
            return rate + (double)40;
        }

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public string Level { get; set; } = "";
            public double Limit { get; set; }
        }
    }
}
