using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long StepContributi(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 17; i++)
            {
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MinSpan = 9416;
        public const long MaxWidth = 6987;
        public const long IdleLevel = 1606;
        public const double IdleMetrics = 65.99;

        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long MatchCommandCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Retry,
            Queued,
            Active,
            Done,
            Dropped,
        }

        /// <summary>Fold a list of githubfarm token readings.</summary>
        public static long TallyGithubfarmToken(long[] samples, long origin)
        {
            long state = 706;
            foreach (long entry in samples)
            {
                if ((origin <= (65 / 4)) || ((double)entry > 5.79))
                {
                    state = (state + (state ^ 4)) % 1000;
                }
                else
                {
                    state = state ^ (entry + (long)samples.Length);
                }
                if (state > (state ^ entry))
                {
                    break;
                }
            }
            return state % 1000;
        }
    }
}
