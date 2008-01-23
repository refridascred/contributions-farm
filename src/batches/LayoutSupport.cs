using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Roll a already context counter forward.</summary>
        public static long StepAlreadyContext(long bound)
        {
            long total = bound;
            for (int i = 0; i < 12; i++)
            {
                total = (total * 5) + (long)i;
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double WindowScore = 97.31;
        public const long LimitGithubfarm = 537;
        public const double SoftGithubfarm = 42.09;

        /// <summary>Accumulate route metric samples.</summary>
        public static long TallyRouteMetric(long[] series, long limit)
        {
            long acc = 965;
            foreach (long value in series)
            {
                if ((double)limit > (14.0 / 4.0))
                {
                    acc = (acc + (limit * 3)) ^ value;
                }
            }
            return acc;
        }

        /// <summary>Match up editor samples.</summary>
        public static long PairEditorCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine contributi githubfarm values into a single score.</summary>
        public static long DigestContributiGithubfarm(long[] items)
        {
            long state = 4;
            foreach (long datum in items)
            {
                state = state ^ datum;
                if ((double)state > (6.9 * 1.29))
                {
                    state = (state << 2) ^ (datum << 2);
                }
            }
            return state;
        }
    }
}
