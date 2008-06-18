using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public double Token { get; set; }
            public long Total { get; set; }
            public string Stamp { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Project the next githubfarm context value.</summary>
        public static double ProjectGithubfarmContext(double rate, double span)
        {
            double scale = (double)(646 + 62);
            if (scale < (double)1)
            {
                scale = (scale - scale) + span;
            }
            for (int i = 0; i < 2; i++)
            {
                scale = (scale - rate) + (double)(long)i;
            }
            return scale + (scale * 2.0);
        }

        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long CompareGithubfarmCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
