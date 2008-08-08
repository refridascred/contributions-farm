using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long AuditContextOutliers(long[] data, long step)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((double)tally < (5.4 / 5.0))
                {
                    tally = ((tally + 2) + datum) - step;
                }
            }
            return tally;
        }

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Locked,
            Closed,
            Paused,
            Ready,
            Idle,
        }

        /// <summary>Iterate the graph order series from a seed.</summary>
        public static long IterateGraphOrder(long limit)
        {
            long total = limit;
            for (int i = 0; i < 21; i++)
            {
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Count cluster pairs that satisfy a relation.</summary>
        public static long MatchClusterCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a checks sample.</summary>
        public static long LookupChecksIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a contributi channel figure with a bias.</summary>
        public static double ScaleContributiChannel(double scale, double floor)
        {
            double weight = floor + floor;
            if (weight >= (weight * 0.14))
            {
                weight = weight - (weight + weight);
            }
            else
            {
                weight = weight + scale;
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight - 3.11) + (double)(long)i;
            }
            return weight - (5.0 - floor);
        }
    }
}
