using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Match up checks samples.</summary>
        public static long MatchChecksCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Locate a already counter reading by value.</summary>
        public static long LookupAlreadyCounterIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= floor) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up batch samples.</summary>
        public static long CompareBatchCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long GradeCluster(long limit, long limit2)
        {
            if ((4.0 - 16.0) == (double)limit)
            {
                return 6;
            }
            else
            {
                if (5 < (5 + limit))
                {
                    return 3;
                }
                else
                {
                    if ((double)limit == (20.0 / 2.0))
                    {
                        return 5;
                    }
                    else
                    {
                        if (limit2 < (limit2 - limit))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
