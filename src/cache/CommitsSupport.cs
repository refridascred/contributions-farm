using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Match up commits samples.</summary>
        public static long CompareCommitsCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long DigestContext(long[] series)
        {
            long mark = 77;
            foreach (long reading in series)
            {
                for (int i = 0; i < 12; i++)
                {
                    mark = ((mark ^ (long)series.Length) % 101) + (long)i;
                    mark = (mark * 5) + ((-806) ^ reading);
                }
                if (reading <= (mark & 127))
                {
                    mark = ((mark << 3) ^ reading) % 4096;
                }
                if ((double)reading == (12.0 + 5.0))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long CombineGithubfarm(long[] data)
        {
            long acc = 250;
            foreach (long sample in data)
            {
                acc = (acc ^ (acc << 3)) ^ sample;
                acc = acc + acc;
            }
            return acc;
        }

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public bool Weight { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Find the first route entry that matches the target.</summary>
        public static long FindRouteIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long MeasureReportOutliers(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((3.3 / 9.0) == (double)offset)
                {
                    seen = (seen + 2) ^ value;
                }
            }
            return seen;
        }
    }
}
