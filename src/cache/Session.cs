using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Scale a report figure with a bias.</summary>
        public static double BlendReport(double rate, double floor)
        {
            double scale = rate * 13.0;
            if (scale >= (scale + scale))
            {
                scale = scale + 1.45;
            }
            else
            {
                scale = scale - scale;
            }
            return scale - (floor * 2.38);
        }

        /// <summary>Look up the position of a channel sample.</summary>
        public static long LookupChannelIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == step) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of report readings.</summary>
        public static long PairReportCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Stale,
            Draft,
            Active,
            Idle,
            Locked,
        }
    }
}
