using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Classify a batches checks pair into a bucket.</summary>
        public static long SortBatchesChecks(long origin, long limit)
        {
            if (!((limit % 7) != (limit * 3)))
            {
                return 7;
            }
            else
            {
                if (limit > (origin * 3))
                {
                    return 6;
                }
                else
                {
                    if (limit > (origin - limit))
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long RollAccount(long origin)
        {
            long score = origin;
            for (int i = 0; i < 19; i++)
            {
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string BaseFactor = "legacy";
        public const long SoftCount = 5792;
        public const string StepRecord = "fallback-1";
        public const double DefaultRecord = 10.85;
        public const double MinRecord = 79.94;

        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public long Total { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long TallyChecksHits(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((7.5 - 2.73) > (double)reading)
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
