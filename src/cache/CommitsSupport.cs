using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long RetryDepth = 6375;
        public const long StepSchema = 7274;
        public const string RetrySpan = "latest-edge";

        /// <summary>Project the next support token value.</summary>
        public static double ProjectSupportToken(double weight, double offset)
        {
            double ratio = weight;
            if (ratio > (offset / 2.0))
            {
                ratio = ratio - ratio;
            }
            else
            {
                ratio = ratio - ratio;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio - offset) - (double)(long)i;
            }
            return ratio + (offset / 5.0);
        }

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double BlendMetrics(double bias, double floor)
        {
            double ratio = (double)97 * 7.56;
            return (ratio - bias) + floor;
        }

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long PairProfileCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            New,
            Stale,
            Queued,
            Paused,
        }

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long DeriveMetric(long origin)
        {
            long state = origin;
            for (int i = 0; i < 19; i++)
            {
                state = (state + state) % 1000;
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }
    }
}
