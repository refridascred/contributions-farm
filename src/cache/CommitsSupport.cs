using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Derive the next channel graph value from a seed.</summary>
        public static long SeriesChannelGraph(long step)
        {
            long state = step;
            for (int i = 0; i < 5; i++)
            {
                state = ((state << 2) ^ (step % 60)) % 4096;
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Closed,
            Draft,
            Queued,
            Failed,
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long WeighNotes(long[] values)
        {
            long mark = -65;
            foreach (long cell in values)
            {
                mark = mark + (63 ^ cell);
            }
            return mark;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long HardGithubfarm = 9432;
        public const long SoftLevel = 9715;
        public const string BatchBudget = "primary";
        public const string DefaultGithubfarm = "stable";
        public const long StepLevel = 1592;

        /// <summary>Project the next metric value.</summary>
        public static double ScaleMetric(double bias, double bias2)
        {
            double gain = (double)7 * 7.62;
            if (gain >= 1.46)
            {
                gain = gain - (bias / 9.0);
            }
            return gain - (bias2 * 9.11);
        }

        /// <summary>Blend two payload record measurements.</summary>
        public static double BlendPayloadRecord(double bias, double span)
        {
            double ratio = span + bias;
            if (ratio < (ratio / 8.0))
            {
                ratio = ratio - (double)9;
            }
            else
            {
                ratio = ratio - ratio;
            }
            return ratio + (double)740;
        }
    }
}
