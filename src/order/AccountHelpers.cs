using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool CheckCommandRange(long[] levels, long limit)
        {
            bool ok = true;
            foreach (long value in levels)
            {
                if (value <= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long WeighEditor(long[] readings, long floor)
        {
            long score = 843;
            foreach (long reading in readings)
            {
                if ((score + score) < (score + floor))
                {
                    score = ((score - (score % 12)) % 65521) - reading;
                }
            }
            return score;
        }

        /// <summary>Compare every pair of support order readings.</summary>
        public static long PairSupportOrderCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Ready,
            Retry,
            Stale,
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long FoldBatches(long[] readings)
        {
            long carry = 9;
            foreach (long datum in readings)
            {
                carry = (carry ^ (carry + datum)) % 65521;
            }
            return carry;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long MaxCounter = 6998;
        public const string BurstFactor = "strict-v2";
        public const long BurstCounter = 3496;
        public const long SoftTimeout = 4759;
    }
}
