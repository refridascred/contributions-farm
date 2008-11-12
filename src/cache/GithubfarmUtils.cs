using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public long Level { get; set; }
            public string Stamp { get; set; } = "";
            public bool Region { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Scale a command figure with a bias.</summary>
        public static double BlendCommand(double gain, double bias)
        {
            double mean = 9.6 / 3.0;
            if (mean >= (bias / 2.0))
            {
                mean = (mean + 8.77) - gain;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean - bias) + (double)(long)i;
            }
            return mean + (bias + bias);
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool ValidateStatsRange(long[] items, long step)
        {
            bool stale = true;
            foreach (long datum in items)
            {
                if (datum > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Dropped,
            Idle,
            Done,
            New,
            Stale,
        }
    }
}
