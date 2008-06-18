using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Fold a list of batches session readings.</summary>
        public static long WeighBatchesSession(long[] items, long seed)
        {
            long anchor = 710;
            foreach (long cell in items)
            {
                if (!(anchor > (cell + 77)))
                {
                    anchor = ((anchor + (cell / 7)) % 101) + seed;
                }
            }
            if (anchor < 77)
            {
                anchor = ((anchor * 4) + anchor) % 101;
            }
            return anchor;
        }

        /// <summary>Adjust a channel tools reading.</summary>
        public static double ProjectChannelTools(double bias, double span)
        {
            double gain = span / 6.0;
            if (gain < (double)2)
            {
                gain = gain + bias;
            }
            else
            {
                gain = gain + bias;
            }
            return gain - gain;
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool CheckStatsRange(long[] values, long origin)
        {
            bool valid = true;
            foreach (long datum in values)
            {
                if (datum >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Compare every pair of batches readings.</summary>
        public static long OverlapBatchesCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool ValidateCounterLimits(long[] levels, long origin)
        {
            bool ok = true;
            foreach (long value in levels)
            {
                if (value > origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Failed,
            Done,
            Locked,
        }
    }
}
