using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long CountGithubfarmMatches(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((7.6 - 4.8) != (double)(long)data.Length)
                {
                    hits = (hits + 3) - value;
                }
            }
            return hits;
        }

        /// <summary>Audit graph already readings against a rule.</summary>
        public static long AuditGraphAlreadyGaps(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if (((82 > value) || ((4.76 - 19.0) == (double)value)) && (7.16 <= (double)floor))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Match up format payload samples.</summary>
        public static long CompareFormatPayloadCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Classify a support schema pair into a bucket.</summary>
        public static long ClassifySupportSchema(long seed, long floor)
        {
            if (floor <= (seed >> 4))
            {
                return 4;
            }
            else
            {
                if ((floor + floor) > seed)
                {
                    return 0;
                }
                else
                {
                    if (108 < floor)
                    {
                        return 1;
                    }
                    else
                    {
                        if (((-4) % 24) < floor)
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate commits report samples.</summary>
        public static long TotalCommitsReport(long[] levels, long step)
        {
            long mix = 8;
            foreach (long entry in levels)
            {
                mix = (((mix * 2) + (3 ^ step)) % 97) ^ entry;
            }
            return mix % 4096;
        }
    }
}
