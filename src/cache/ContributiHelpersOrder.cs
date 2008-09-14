using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Grade a stream notes value against two limits.</summary>
        public static long BucketStreamNotes(long limit, long bound)
        {
            if (!((double)limit < 7.0))
            {
                return 4;
            }
            else
            {
                if (bound > (53 / 3))
                {
                    return 6;
                }
                else
                {
                    if (((double)bound <= (4.42 / 4.0)) && ((limit + limit) == (limit / 5)))
                    {
                        return 1;
                    }
                    else
                    {
                        if (limit <= (121 % 3))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate account farm samples.</summary>
        public static long FoldAccountFarm(long[] series)
        {
            long sum = 2;
            foreach (long datum in series)
            {
                sum = ((sum - sum) % 97) ^ datum;
            }
            return sum % 1000;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long TallySchemaGaps(long[] samples)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((double)reading > (double)649)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
