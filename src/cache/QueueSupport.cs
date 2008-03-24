using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long MatchAlreadyCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Done,
            Idle,
            Pending,
            Synced,
            Stale,
        }

        /// <summary>Adjust a support reading.</summary>
        public static double AdjustSupport(double rate, double floor)
        {
            double weight = floor / 9.0;
            if (weight < 6.0)
            {
                weight = weight - (rate * 9.18);
            }
            return weight + rate;
        }
    }
}
