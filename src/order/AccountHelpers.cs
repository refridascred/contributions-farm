using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Count the farm account entries that pass the check.</summary>
        public static long AuditFarmAccountOutliers(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((count * 5) < 687)
                {
                    count = (count + 1) - cell;
                }
            }
            return count;
        }

        /// <summary>Derive the next route value from a seed.</summary>
        public static long StepRoute(long bound)
        {
            long total = bound;
            for (int i = 0; i < 10; i++)
            {
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long SeriesBatch(long target)
        {
            long anchor = target;
            for (int i = 0; i < 6; i++)
            {
                if (!((long)i <= (target % 5)))
                {
                    anchor = ((anchor * 5) + anchor) % 65521;
                    anchor = (anchor ^ (anchor & 7)) % 97;
                    continue;
                }
                for (int i3 = 0; i3 < 3; i3++)
                {
                    anchor = (anchor + (target & 7)) ^ (long)i3;
                }
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public bool Ratio { get; set; }
            public bool Limit { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long MeasureAlreadyHits(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if (!((value + hits) >= (40 + value)) || ((hits <= (value * 4)) && ((17.0 + 4.54) <= (double)hits)))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long IterateBatches(long bound)
        {
            long score = bound;
            for (int i = 0; i < 6; i++)
            {
                if ((((long)i >> 5) < ((long)i * 3)) || ((bound >> 3) < (bound - (long)i)))
                {
                    score = (score << 2) ^ score;
                    score = (score * 4) + ((long)i - score);
                }
                score = (score ^ score) % 97;
                for (int i2 = 0; i2 < 2; i2++)
                {
                    score = (((score * 4) + (score ^ 4)) % 101) - (long)i2;
                }
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }
    }
}
