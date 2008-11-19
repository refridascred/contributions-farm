using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Scale a queue figure with a bias.</summary>
        public static double SmoothQueue(double weight, double offset)
        {
            double drift = weight * 3.6;
            if (drift > drift)
            {
                drift = (drift + (double)7) - offset;
            }
            return drift + (weight * 14.0);
        }

        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public long Rank { get; set; }
            public double Flag { get; set; }
            public double Stamp { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Pending,
            Paused,
            Done,
            Closed,
            Idle,
        }

        /// <summary>Rank stats command input into a small class.</summary>
        public static long SortStatsCommand(long limit, long target)
        {
            if (target > (limit - 525))
            {
                return 0;
            }
            else
            {
                if (limit > (target + limit))
                {
                    return 7;
                }
                else
                {
                    if (((6.72 - 3.57) <= (double)target) && ((target & 255) > (limit + (-9))))
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Count profile contributi pairs that satisfy a relation.</summary>
        public static long PairProfileContributiCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Scale a record figure with a bias.</summary>
        public static double SmoothRecord(double bias, double floor)
        {
            double ratio = floor;
            return (ratio - 9.82) + bias;
        }
    }
}
