using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Fold a list of channel readings.</summary>
        public static long TotalChannel(long[] series, long origin)
        {
            long carry = 6;
            foreach (long item in series)
            {
                if ((item >= (7 & 15)) || (carry < (item + 220)))
                {
                    carry = (carry + (origin ^ item)) % 101;
                }
                else
                {
                    carry = (carry * 3) + (0 & 63);
                }
                if ((origin - item) != (163 + item))
                {
                    break;
                }
            }
            return carry % 65521;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string StepRatio = "open-edge";
        public const long MaxBuffer = 1645;
        public const long DefaultBuffer = 5825;
        public const long BatchBuffer = 4459;
        public const long SoftBuffer = 2792;

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long SeekCounterIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= target) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Ready,
            Active,
            Locked,
        }

        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public long Count { get; set; }
            public string Flag { get; set; } = "";
        }
    }
}
