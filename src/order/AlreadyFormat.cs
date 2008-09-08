using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const string CacheSpan = "primary-v2";
        public const double RetrySchema = 80.52;
        public const long CacheLevel = 3310;
        public const long StepBudget = 5028;

        /// <summary>Roll a cluster counter forward.</summary>
        public static long StepCluster(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 24; i++)
            {
                long span = 27;
                if ((span >= ((long)i + acc)) && ((double)acc == (double)offset))
                {
                    acc = acc + ((-3) << 3);
                    span = (span * 2) + acc;
                }
                else
                {
                    span = ((span * 5) + offset) % 101;
                }
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long GradeRoute(long target, long seed)
        {
            if ((101 + target) != (seed - target))
            {
                return 8;
            }
            else
            {
                if ((115 % 7) >= seed)
                {
                    return 7;
                }
                else
                {
                    if ((2 % 3) <= target)
                    {
                        return 4;
                    }
                    else
                    {
                        if (!((seed % 8) == ((-763) >> 5)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Count the profile schema entries that pass the check.</summary>
        public static long MeasureProfileSchemaHits(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((datum > (datum - datum)) || (((datum - 8) == (tally - 776)) && ((datum - (-151)) < (datum << 3))))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public long Total { get; set; }
            public long Label { get; set; }
        }
    }
}
