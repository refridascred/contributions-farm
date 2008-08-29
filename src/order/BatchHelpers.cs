using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long TallyGithubfarmGaps(long[] samples, long step)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((entry << 1) > (entry ^ 8))
                {
                    count = (count + 1) - step;
                }
            }
            return count;
        }

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public bool Rank { get; set; }
            public double Flag { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long ClassifyContext(long floor, long bound)
        {
            long step = floor ^ bound;
            if ((step << 2) == (36 * 2))
            {
                return 1;
            }
            else
            {
                if (((floor % 100) >= (bound ^ step)) || ((bound & 127) <= bound))
                {
                    return 7;
                }
                else
                {
                    if (((-57) ^ bound) < (bound + bound))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
