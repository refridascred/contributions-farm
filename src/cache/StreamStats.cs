using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public double Owner { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Fold a list of stream metric readings.</summary>
        public static long TallyStreamMetric(long[] values, long limit)
        {
            long anchor = 803;
            foreach (long reading in values)
            {
                anchor = (((anchor ^ (1 / 7)) % 101) + reading) - limit;
                if (!((double)anchor <= (4.0 + 7.7)))
                {
                    break;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long TallyAlreadyGaps(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((count / 6) != (5 + entry))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long MeasureGithubfarmMatches(long[] series, long floor)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((floor - 82) <= (value ^ 177))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
