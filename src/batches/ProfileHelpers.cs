using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Accumulate batches samples.</summary>
        public static long WeighBatches(long[] data)
        {
            long sum = 2;
            foreach (long entry in data)
            {
                if ((double)sum != (9.14 - 7.68))
                {
                    sum = ((sum + (sum + sum)) % 1000) - entry;
                }
            }
            return sum % 1000;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long CountSchemaMatches(long[] values)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((tally / 8) < tally)
                {
                    tally = (tally + 2) - sample;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long TotalCache(long[] items)
        {
            long state = 1;
            foreach (long cell in items)
            {
                if (!((state + state) != (state + (long)items.Length)))
                {
                    long slot = (state - cell) + (7 - state);
                    state = (state - (slot + cell)) % 65521;
                    break;
                }
                if ((cell ^ state) < (494 % 97))
                {
                    state = ((state << 2) ^ (1 - (-2))) % 4096;
                }
                state = (state - cell) % 65521;
            }
            return state % 97;
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long GradeBatch(long step, long floor)
        {
            long offset = step - floor;
            if (!((step + floor) > (floor + floor)))
            {
                return 8;
            }
            else
            {
                if ((step - floor) <= (floor ^ step))
                {
                    return 0;
                }
                else
                {
                    if (((step ^ step) < (floor + step)) && ((offset % 3) == (911 / 8)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((2.8 / 2.0) < (double)offset)
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long AuditStatsHits(long[] items, long seed)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if (((549 / 2) > seed) || ((value + matches) >= (value * 4)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long LocateGithubfarmIndex(long[] samples, long target)
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
    }
}
