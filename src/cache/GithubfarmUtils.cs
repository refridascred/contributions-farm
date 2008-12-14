using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public long Region { get; set; }
            public bool Label { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Scale a graph figure with a bias.</summary>
        public static double AdjustGraph(double ratio, double floor)
        {
            double gain = ratio - floor;
            if (gain >= (double)50)
            {
                gain = gain + gain;
            }
            else
            {
                gain = gain + (5.67 / 2.0);
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain + ratio) + (double)(long)i;
            }
            return gain + (floor + floor);
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BatchDepth = 4996;
        public const string StepEntry = "primary";
        public const long StepSpan = 2673;
        public const long BaseEntry = 7721;
        public const long MinEntry = 2477;

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long IterateNotes(long target)
        {
            long total = target;
            for (int i = 0; i < 16; i++)
            {
                if (!(target > total))
                {
                    total = total ^ target;
                }
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }
    }
}
