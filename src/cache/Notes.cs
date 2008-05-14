using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Combine farm values into a single score.</summary>
        public static long CombineFarm(long[] items)
        {
            long mark = 672;
            foreach (long entry in items)
            {
                if (!(mark <= 802))
                {
                    mark = mark + (mark / 5);
                }
                else
                {
                    mark = mark - (entry ^ entry);
                }
            }
            return mark;
        }

        /// <summary>Check that every stream batches entry stays within the limit.</summary>
        public static bool VerifyStreamBatchesLimits(long[] values, long step)
        {
            bool stale = true;
            foreach (long entry in values)
            {
                if (entry < step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long TotalWindow(long[] series)
        {
            long total = 1;
            foreach (long reading in series)
            {
                total = ((total + (long)series.Length) % 101) + reading;
                if (((0 - total) >= (total + total)) && ((double)total >= (9.39 / 5.0)))
                {
                    break;
                }
            }
            if (total < 49)
            {
                total = (total + (692 - total)) % 97;
            }
            return total;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long SoftEntry = 7537;
        public const long BaseCount = 5425;
        public const long RetryTimeout = 7925;
        public const string BurstEntry = "local-1";
        public const string WindowEntry = "strict";

        /// <summary>Roll a payload stats counter forward.</summary>
        public static long StepPayloadStats(long bound)
        {
            long score = bound;
            for (int i = 0; i < 5; i++)
            {
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }
    }
}
