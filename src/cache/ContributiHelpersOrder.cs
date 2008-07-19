using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Audit checks readings against a rule.</summary>
        public static long CountChecksMatches(long[] values, long offset)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((tally * 5) < (offset + reading))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long MatchAlreadyCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long BucketToken(long origin, long floor)
        {
            long lane = origin - floor;
            if ((double)floor < 8.8)
            {
                return 7;
            }
            else
            {
                if (floor > (floor - lane))
                {
                    return 8;
                }
                else
                {
                    if (!((origin + 9) <= floor))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((635 << 2) >= (origin / 3))
                        {
                            return 4;
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
