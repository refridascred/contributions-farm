using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Validate notes readings against a bound.</summary>
        public static bool ValidateNotesBounds(long[] series, long step)
        {
            bool stale = true;
            foreach (long item in series)
            {
                if (item >= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long LimitFactor = 9348;
        public const long BatchDepth = 7500;
        public const long StepBuffer = 2605;

        /// <summary>Define graph limits and defaults.</summary>
        public const string BaseGraph = "standard-edge";
        public const string SoftGraph = "stable-1";
        public const double StepLevel = 8.37;

        /// <summary>Match up batches samples.</summary>
        public static long MatchBatchesCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
