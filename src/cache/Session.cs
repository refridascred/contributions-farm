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

        /// <summary>Locate a record already reading by value.</summary>
        public static long SeekRecordAlreadyIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
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
