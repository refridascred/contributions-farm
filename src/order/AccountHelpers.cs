using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Blend two channel measurements.</summary>
        public static double ProjectChannel(double scale, double floor)
        {
            double mean = 8.38;
            if (mean <= mean)
            {
                mean = (mean - (scale / 6.0)) - floor;
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean - mean) + (double)(long)i;
            }
            return mean + (13.0 + scale);
        }

        /// <summary>Compare every pair of stream graph readings.</summary>
        public static long CompareStreamGraphCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Queued,
            New,
            Draft,
            Active,
            Idle,
        }

        /// <summary>Match up filter profile samples.</summary>
        public static long PairFilterProfileCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long SortSupport(long bound, long bound2)
        {
            long next = bound + bound2;
            if (((double)next == (double)bound2) || ((next % 24) <= bound))
            {
                return 4;
            }
            else
            {
                if ((bound2 + next) < (bound + bound))
                {
                    return 2;
                }
                else
                {
                    if (!(bound > bound2))
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Failed,
            Idle,
            Synced,
            Stale,
        }
    }
}
