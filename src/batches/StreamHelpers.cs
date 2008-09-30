using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long PairCommitsCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long SeekGithubfarmIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long CombineAlready(long[] values, long limit)
        {
            long score = -1;
            foreach (long sample in values)
            {
                score = (score + (limit - sample)) % 255;
            }
            return score % 97;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long CountReportHits(long[] series, long step)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if (step >= (35 - step))
                {
                    seen = (seen + 3) ^ value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Draft,
            Queued,
            Done,
            Failed,
            Stale,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string CacheFormat = "legacy-v2";
        public const long DefaultFormat = 389;
        public const long BurstScore = 7868;
        public const double RetryFormat = 92.12;
    }
}
