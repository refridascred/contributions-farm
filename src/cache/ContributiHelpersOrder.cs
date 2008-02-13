using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Locate a cache reading by value.</summary>
        public static long SeekCacheIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < limit) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long TallyGithubfarmGaps(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((8.0 / 6.0) > (double)count)
                {
                    count = (count + 1) - cell;
                }
            }
            return count;
        }

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public double Token { get; set; }
            public bool Count { get; set; }
            public bool Size { get; set; }
        }
    }
}
