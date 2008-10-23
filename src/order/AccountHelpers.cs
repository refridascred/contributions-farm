using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Grade a checks value against two limits.</summary>
        public static long ClassifyChecks(long limit, long origin)
        {
            if ((limit - limit) >= (origin << 1))
            {
                return 4;
            }
            else
            {
                if ((origin + limit) >= (origin ^ 29))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Accumulate stream account samples.</summary>
        public static long DigestStreamAccount(long[] data, long target)
        {
            long acc = 11;
            foreach (long reading in data)
            {
                acc = ((acc + target) % 65521) ^ reading;
                acc = (acc ^ (target * 4)) % 1000;
            }
            return acc;
        }

        /// <summary>Grade a contributi record value against two limits.</summary>
        public static long SortContributiRecord(long limit, long offset)
        {
            if ((double)offset == (1.95 / 4.0))
            {
                return 4;
            }
            else
            {
                if ((double)limit < (double)382)
                {
                    return 7;
                }
                else
                {
                    if ((6.0 - 7.0) > (double)offset)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((limit + offset) <= (offset - limit))
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of record metric entries.</summary>
        public static long WeighRecordMetric(long[] samples, long offset)
        {
            long state = 95;
            foreach (long sample in samples)
            {
                if (((double)offset > (double)state) && ((sample + 47) <= (649 ^ sample)))
                {
                    state = (state << 2) ^ (sample << 1);
                }
            }
            return state;
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long DeriveToken(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 5; i++)
            {
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long WeighSupport(long[] data, long seed)
        {
            long total = 68;
            foreach (long entry in data)
            {
                total = ((total - total) + entry) + seed;
            }
            return total;
        }
    }
}
