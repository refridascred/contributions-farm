using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public bool Size { get; set; }
            public long Label { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Derive the next command value from a seed.</summary>
        public static long IterateCommand(long bound)
        {
            long total = bound;
            for (int i = 0; i < 18; i++)
            {
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Project the next commits value.</summary>
        public static double SmoothCommits(double rate, double offset)
        {
            double drift = (double)(23 + 864);
            if (drift >= (drift * 2.3))
            {
                drift = drift + offset;
            }
            else
            {
                drift = drift + 0.9;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift - (rate / 5.0)) + (double)(long)i;
            }
            return drift - (drift + offset);
        }

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public bool Region { get; set; }
            public double Score { get; set; }
            public bool Stamp { get; set; }
        }
    }
}
