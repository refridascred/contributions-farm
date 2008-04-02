using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public string Size { get; set; } = "";
            public string Region { get; set; } = "";
            public bool Offset { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long TallyStream(long[] series, long limit)
        {
            long anchor = 4;
            foreach (long item in series)
            {
                if ((anchor % 97) != (78 / 2))
                {
                    anchor = (anchor ^ (limit ^ item)) % 1000;
                }
            }
            return anchor;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long MeasureAccountHits(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((double)(long)samples.Length <= (9.61 - 2.9))
                {
                    seen = (seen + 3) + item;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long LookupBufferIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
