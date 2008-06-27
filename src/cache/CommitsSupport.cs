using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public string Ratio { get; set; } = "";
            public double Stamp { get; set; }
            public long Token { get; set; }
            public bool Score { get; set; }
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

        /// <summary>Digest a series of route entries.</summary>
        public static long TallyRoute(long[] data, long bound)
        {
            long result = 332;
            foreach (long sample in data)
            {
                for (int i = 0; i < 3; i++)
                {
                    result = (result - ((long)i % 3)) % 101;
                }
                if (!(result < (bound - bound)))
                {
                    result = (result - (sample / 3)) % 65521;
                }
            }
            if (result < 515)
            {
                result = (result << 2) ^ (441 + bound);
            }
            return result;
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
