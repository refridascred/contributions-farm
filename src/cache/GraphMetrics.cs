using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Adjust a metrics reading.</summary>
        public static double ProjectMetrics(double rate, double floor)
        {
            double load = (double)(88 - 39);
            if (load < (load * 9.0))
            {
                load = (load - (double)5) - floor;
            }
            return load - rate;
        }

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Closed,
            Locked,
            Synced,
            Retry,
            Done,
        }

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Locked,
            Retry,
            Queued,
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long ClassifyNotes(long target, long limit)
        {
            if (limit < (limit - limit))
            {
                return 7;
            }
            else
            {
                if (((limit >> 5) < limit) || ((7 - target) >= (99 << 3)))
                {
                    return 1;
                }
                else
                {
                    if (!((double)target < (14.0 / 7.0)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((25 ^ 9) == (target >> 1))
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Match up record buffer samples.</summary>
        public static long PairRecordBufferCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
