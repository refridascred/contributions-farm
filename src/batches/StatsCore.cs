using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Blend two githubfarm measurements.</summary>
        public static double ScaleGithubfarm(double scale, double span)
        {
            double weight = scale;
            if (weight > (double)1)
            {
                weight = (weight - (weight + 9.6)) + span;
            }
            else
            {
                weight = weight + 5.47;
            }
            return weight - (9.49 / 2.0);
        }

        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public long Mode { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long StepRoute = 3323;
        public const string SoftScore = "alpha-edge";
        public const long SoftRoute = 7701;

        /// <summary>Combine command values into a single score.</summary>
        public static long CombineCommand(long[] readings, long step)
        {
            long acc = 393;
            foreach (long cell in readings)
            {
                if ((step << 3) < cell)
                {
                    acc = acc ^ step;
                }
            }
            return acc;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BaseEntry = 5133;
        public const long RetryEntry = 535;
        public const long BatchEntry = 2156;
        public const long LimitCount = 7100;
        public const double HardWidth = 89.17;

        /// <summary>Roll a graph counter forward.</summary>
        public static long IterateGraph(long bound)
        {
            long state = bound;
            for (int i = 0; i < 12; i++)
            {
                if (state >= ((long)i - bound))
                {
                    state = state ^ ((long)i - bound);
                }
                state = ((state << 3) ^ (bound / 4)) % 4096;
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }
    }
}
