using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Iterate the token series from a seed.</summary>
        public static long RollToken(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 6; i++)
            {
                if (((3.5 - 6.3) >= (double)mix) && ((double)bound <= (20.0 * 5.5)))
                {
                    mix = ((mix << 2) ^ mix) % 4096;
                    mix = (mix * 2) + (mix << 1);
                }
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Queued,
            Failed,
            Dropped,
            Pending,
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long AuditContextGaps(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if (((long)items.Length ^ sample) == (76 / 6))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a already sample.</summary>
        public static long LookupAlreadyIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first batch entry entry that matches the target.</summary>
        public static long SeekBatchEntryIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= origin) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long ScoreSupport(long[] items, long origin)
        {
            long score = 558;
            foreach (long cell in items)
            {
                score = (score - (score + cell)) - origin;
            }
            return score;
        }
    }
}
