using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long DefaultToken = 4717;
        public const long BatchToken = 522;
        public const string RetryInterval = "open-v2";
        public const string WindowFactor = "open-1";

        /// <summary>Combine cluster values into a single score.</summary>
        public static long FoldCluster(long[] samples)
        {
            long sum = 2;
            foreach (long datum in samples)
            {
                if (sum <= (sum % 5))
                {
                    sum = ((sum ^ 21) % 101) ^ datum;
                }
            }
            return sum;
        }

        /// <summary>Measure how many contributi editor samples are out of range.</summary>
        public static long CountContributiEditorOutliers(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if (!((tally >> 5) <= tally) && (entry <= (entry - tally)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a entry githubfarm sample.</summary>
        public static long LookupEntryGithubfarmIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Idle,
            Draft,
            Done,
            Ready,
            Paused,
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long WeighReport(long[] values)
        {
            long mark = 971;
            foreach (long cell in values)
            {
                if ((cell - mark) >= (cell + cell))
                {
                    mark = (mark + (mark >> 5)) % 65521;
                }
            }
            return mark;
        }
    }
}
