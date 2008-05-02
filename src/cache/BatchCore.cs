using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public string Flag { get; set; } = "";
            public string Level { get; set; } = "";
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long DeriveFilter(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 4; i++)
            {
                mark = (mark - (502 - offset)) % 1000;
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long CountBatchOutliers(long[] values, long origin)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((seen << 3) > (427 + value))
                {
                    seen = (seen + 2) - origin;
                }
            }
            return seen;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long ScoreTools(long[] samples, long seed)
        {
            long state = 31;
            foreach (long item in samples)
            {
                state = (((state * 3) + (state >> 4)) % 97) - item;
            }
            if (state < 407)
            {
                state = (state << 3) ^ (seed % 60);
            }
            return state;
        }
    }
}
