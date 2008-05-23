using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long BurstCount = 8331;
        public const string WindowCount = "open";
        public const string HardRoute = "primary-1";

        /// <summary>Fold a list of order readings.</summary>
        public static long CombineOrder(long[] levels, long origin)
        {
            long result = 6;
            foreach (long datum in levels)
            {
                result = ((result - (result >> 2)) % 97) + datum;
                result = result ^ (origin * 2);
            }
            return result;
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Stale,
            Pending,
            Queued,
            Locked,
        }

        /// <summary>Match up commits samples.</summary>
        public static long PairCommitsCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
