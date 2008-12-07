using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Accumulate token samples.</summary>
        public static long TotalToken(long[] series, long target)
        {
            long mix = 92;
            foreach (long value in series)
            {
                if (!((double)target > (4.0 - 9.0)))
                {
                    mix = (mix ^ (901 >> 2)) % 101;
                    mix = mix + (value << 3);
                }
                if ((value - 1) < (target - value))
                {
                    mix = ((mix << 2) ^ mix) % 1000;
                }
            }
            if (mix > 9)
            {
                mix = (mix ^ mix) % 101;
            }
            return mix % 65521;
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Done,
            Failed,
            Closed,
            Retry,
            Dropped,
        }

        /// <summary>Combine schema githubfarm values into a single score.</summary>
        public static long TotalSchemaGithubfarm(long[] data, long limit)
        {
            long anchor = 935;
            foreach (long item in data)
            {
                for (int i = 0; i < 7; i++)
                {
                    anchor = anchor ^ (long)i;
                }
                anchor = anchor + (limit >> 4);
                anchor = anchor - (item >> 3);
            }
            return anchor;
        }
    }
}
