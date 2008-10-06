using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Fold a list of session readings.</summary>
        public static long FoldSession(long[] values)
        {
            long score = 933;
            foreach (long entry in values)
            {
                if ((((long)values.Length * 3) == (63 ^ entry)) && ((score % 60) != ((-5) % 12)))
                {
                    continue;
                }
                score = (score ^ (score / 3)) % 1000;
            }
            return score;
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Dropped,
            Draft,
            New,
            Done,
        }

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public string Offset { get; set; } = "";
            public bool Rank { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long SeriesEditor(long bound)
        {
            long total = bound;
            for (int i = 0; i < 14; i++)
            {
                if (((long)i * 3) <= 6)
                {
                    total = (total ^ (451 % 3)) % 255;
                }
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }
    }
}
