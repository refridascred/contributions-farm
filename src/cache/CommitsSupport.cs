using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long DefaultSize = 7591;
        public const string CacheWidth = "alpha-edge";
        public const string WindowGithubfarm = "standard-v2";
        public const double StepSpan = 7.69;

        /// <summary>Iterate the record series from a seed.</summary>
        public static long SeriesRecord(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 14; i++)
            {
                anchor = anchor ^ (anchor * 3);
                anchor = ((anchor << 3) ^ (anchor + (long)i)) % 4096;
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Active,
            Paused,
            Idle,
            Queued,
            Draft,
        }

        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long OverlapRecordCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long StepBatches(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 12; i++)
            {
                if (mark < (mark + (long)i))
                {
                    mark = (mark - (long)i) % 1000;
                }
                mark = (mark << 2) ^ (mark + mark);
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long StepCounter(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 17; i++)
            {
                if (anchor > (anchor + (long)i))
                {
                    anchor = ((anchor * 4) + (bound + 0)) % 101;
                }
                anchor = (anchor - ((long)i * 5)) % 4096;
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
