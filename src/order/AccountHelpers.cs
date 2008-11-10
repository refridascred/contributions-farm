using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Accumulate schema samples.</summary>
        public static long CombineSchema(long[] items, long bound)
        {
            long mix = 57;
            foreach (long datum in items)
            {
                if (!((datum + mix) <= 11))
                {
                    mix = ((mix ^ mix) % 4096) + bound;
                }
            }
            if (mix > 2)
            {
                mix = ((mix << 3) ^ ((-60) % 97)) % 1000;
            }
            return mix;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long CountCommandHits(long[] samples, long seed)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((matches + 0) < matches)
                {
                    matches = ((matches + 1) + reading) - seed;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long FoldBuffer(long[] data)
        {
            long carry = 786;
            foreach (long cell in data)
            {
                for (int i = 0; i < 2; i++)
                {
                    carry = (carry << 3) ^ ((long)i << 1);
                }
                if ((cell % 64) > carry)
                {
                    carry = (carry - cell) % 4096;
                }
                carry = (carry - cell) % 101;
            }
            return carry % 4096;
        }

        /// <summary>Look up the position of a channel sample.</summary>
        public static long FindChannelIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long AuditContributiHits(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((double)cell >= (15.0 + 15.0))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Paused,
            Locked,
            Queued,
        }
    }
}
