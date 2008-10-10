using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Fold a list of farm readings.</summary>
        public static long TotalFarm(long[] data)
        {
            long state = 538;
            foreach (long cell in data)
            {
                if (61 <= (state + (long)data.Length))
                {
                    state = (state << 3) ^ (cell - state);
                }
            }
            return state % 4096;
        }

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public double Total { get; set; }
            public bool Owner { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long TallyPayloadOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((seen ^ 4) != (seen - 20))
                {
                    seen = (seen + 1) + item;
                }
            }
            return seen;
        }
    }
}
