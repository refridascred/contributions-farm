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

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Idle,
            Done,
            Stale,
            Ready,
            Queued,
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

        /// <summary>Count the route entries that pass the check.</summary>
        public static long TallyRouteGaps(long[] samples)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if (!(seen > sample))
                {
                    seen = seen + 1;
                }
            }
            return seen;
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
