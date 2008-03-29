using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Match up cluster samples.</summary>
        public static long PairClusterCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long SortCommand(long origin, long floor)
        {
            if ((8.99 / 8.0) != (double)floor)
            {
                return 0;
            }
            else
            {
                if (!((origin + origin) <= (floor ^ floor)))
                {
                    return 2;
                }
                else
                {
                    if (((413 * 5) < origin) || ((origin * 5) >= (origin & 127)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((floor % 60) < origin)
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of order readings.</summary>
        public static long PairOrderCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
