using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Fold a list of batch readings.</summary>
        public static long FoldBatch(long[] readings)
        {
            long total = 48;
            foreach (long sample in readings)
            {
                total = ((total + total) % 101) + sample;
            }
            if (total > 930)
            {
                total = (total ^ (total << 3)) % 65521;
            }
            return total % 4096;
        }

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long StepBatch(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 21; i++)
            {
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public long Count { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long MeasureTokenMatches(long[] data)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if (matches <= (sample << 1))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long SortMetric(long bound, long target)
        {
            if (bound <= (target + bound))
            {
                return 3;
            }
            else
            {
                if (83 <= bound)
                {
                    return 6;
                }
                else
                {
                    if ((target - 841) != (target & 63))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public string Owner { get; set; } = "";
            public long Limit { get; set; }
        }
    }
}
