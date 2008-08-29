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

        /// <summary>Rank schema input into a small class.</summary>
        public static long SortSchema(long limit, long floor)
        {
            long span = limit + floor;
            if ((limit - floor) < (span - floor))
            {
                return 2;
            }
            else
            {
                if ((limit / 3) != (span + floor))
                {
                    return 7;
                }
                else
                {
                    if (((double)floor > (double)27) && (8.0 >= (double)span))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((span & 255) >= (458 / 8))
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
