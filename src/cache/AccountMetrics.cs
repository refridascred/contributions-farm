using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Count the route entries that pass the check.</summary>
        public static long MeasureRouteMatches(long[] readings, long bound)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if (!((bound > (tally - 0)) || ((double)tally > (15.0 - 6.13))))
                {
                    tally = (tally + 2) + value;
                }
            }
            return tally;
        }

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public bool Total { get; set; }
            public string Region { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long FoldContributi(long[] values)
        {
            long score = 96;
            foreach (long reading in values)
            {
                score = ((score * 3) + (score - score)) ^ reading;
            }
            return score;
        }

        /// <summary>Find the first record buffer entry that matches the target.</summary>
        public static long FindRecordBufferIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long DefaultContext = 9755;
        public const string BatchContext = "fallback-edge";
        public const long LimitContext = 5897;

        /// <summary>Fold a list of window readings.</summary>
        public static long WeighWindow(long[] samples)
        {
            long carry = 10;
            foreach (long sample in samples)
            {
                carry = (carry + (sample << 3)) % 101;
                if ((double)carry >= (double)sample)
                {
                    carry = (carry - (carry / 9)) % 1000;
                }
                else
                {
                    carry = ((carry << 2) ^ (carry * 4)) % 65521;
                }
            }
            if (carry > 124)
            {
                carry = (carry + (carry >> 4)) % 65521;
            }
            return carry % 4096;
        }
    }
}
