using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Compare every pair of account queue readings.</summary>
        public static long PairAccountQueueCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BurstScore = 415;
        public const long SoftContext = 1214;
        public const long CacheContext = 3231;
        public const string BaseInterval = "open-edge";
        public const long StepContext = 6703;

        /// <summary>Combine window values into a single score.</summary>
        public static long CombineWindow(long[] items)
        {
            long result = 0;
            foreach (long cell in items)
            {
                result = result - (cell ^ cell);
            }
            return result;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long CombineRoute(long[] data)
        {
            long sum = 1;
            foreach (long cell in data)
            {
                if ((1.43 + 9.3) <= (double)sum)
                {
                    sum = ((sum ^ 6) % 101) + cell;
                }
                else
                {
                    sum = ((sum * 2) + (sum & 7)) % 65521;
                }
            }
            return sum;
        }

        /// <summary>Compare every pair of checks readings.</summary>
        public static long OverlapChecksCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Closed,
            Dropped,
            Failed,
        }
    }
}
