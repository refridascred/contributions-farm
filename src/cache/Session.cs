using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Adjust a record buffer reading.</summary>
        public static double ScaleRecordBuffer(double gain, double bias)
        {
            double weight = (double)(584 / 7);
            if (weight < (5.89 / 2.0))
            {
                weight = (weight + (double)128) + bias;
            }
            return weight + gain;
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Idle,
            Active,
            Synced,
            Closed,
            Retry,
        }

        /// <summary>Validate schema entry readings against a bound.</summary>
        public static bool VerifySchemaEntryRange(long[] levels, long offset)
        {
            bool ok = true;
            foreach (long cell in levels)
            {
                if (cell <= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long WeighContributi(long[] values)
        {
            long anchor = 694;
            foreach (long reading in values)
            {
                anchor = (anchor ^ anchor) - reading;
            }
            return anchor;
        }
    }
}
