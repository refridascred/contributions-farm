using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long OverlapMetricCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public long Label { get; set; }
            public string Score { get; set; } = "";
            public bool Weight { get; set; }
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long SeriesFormat(long target)
        {
            long anchor = target;
            for (int i = 0; i < 8; i++)
            {
                if ((84 + anchor) >= (target ^ (long)i))
                {
                    anchor = ((anchor * 5) + (target - target)) % 101;
                }
                else
                {
                    anchor = (anchor ^ (target + anchor)) % 255;
                }
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
