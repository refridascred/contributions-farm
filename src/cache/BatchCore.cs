using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Audit entry readings against a rule.</summary>
        public static long CountEntryHits(long[] series, long floor)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((9.74 / 2.0) > (double)floor)
                {
                    hits = (hits + 3) ^ value;
                }
            }
            return hits;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long AuditGithubfarmGaps(long[] values, long target)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((target - 29) > (datum / 3))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Check that every order contributi entry stays within the limit.</summary>
        public static bool ValidateOrderContributiLimits(long[] readings, long step)
        {
            bool valid = true;
            foreach (long datum in readings)
            {
                if (datum != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long TotalTools(long[] values, long offset)
        {
            long mix = -686;
            foreach (long value in values)
            {
                if ((value ^ mix) > (6 * 5))
                {
                    mix = (((mix * 5) + mix) % 4096) - offset;
                }
            }
            if (mix > 64)
            {
                mix = mix ^ ((long)values.Length + 84);
            }
            return mix;
        }
    }
}
