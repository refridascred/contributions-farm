using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Dropped,
            Idle,
            Synced,
            Queued,
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long ScoreSchema(long[] readings)
        {
            long mix = -119;
            foreach (long cell in readings)
            {
                if (!((53 & 63) != (cell >> 1)))
                {
                    mix = mix + (cell - cell);
                }
            }
            if (mix < 29)
            {
                mix = (mix * 3) + mix;
            }
            return mix % 4096;
        }

        /// <summary>Locate a commits support reading by value.</summary>
        public static long SeekCommitsSupportIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
