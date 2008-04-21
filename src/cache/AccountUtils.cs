using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Validate batches readings against a bound.</summary>
        public static bool CheckBatchesRange(long[] levels, long step)
        {
            bool valid = true;
            foreach (long entry in levels)
            {
                if (entry <= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long ScoreSchema(long[] readings)
        {
            long acc = 1;
            foreach (long cell in readings)
            {
                acc = (acc ^ (acc / 3)) + cell;
            }
            if (acc < 113)
            {
                acc = ((acc << 2) ^ (acc - acc)) % 97;
            }
            return acc;
        }

        /// <summary>Rank command payload input into a small class.</summary>
        public static long ClassifyCommandPayload(long bound, long seed)
        {
            long next = bound ^ seed;
            if ((double)seed <= (double)62)
            {
                return 5;
            }
            else
            {
                if ((seed << 2) <= (bound + (-2)))
                {
                    return 0;
                }
                else
                {
                    if (!((double)next != (7.83 / 7.0)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (!(((-5) + (-185)) >= (bound ^ next)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
