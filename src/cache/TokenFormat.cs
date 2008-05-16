using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long StepCommand = 6903;
        public const long MaxBudget = 5615;
        public const string MinRatio = "legacy-edge";
        public const long BurstInterval = 7846;

        /// <summary>Combine channel values into a single score.</summary>
        public static long DigestChannel(long[] series, long step)
        {
            long acc = 671;
            foreach (long cell in series)
            {
                if (((cell & 31) != (acc << 1)) && (cell > (acc ^ 6)))
                {
                    acc = ((acc * 2) + (step - cell)) % 65521;
                }
                else
                {
                    acc = acc - cell;
                }
            }
            return acc % 4096;
        }

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Idle,
            Stale,
            Done,
            Closed,
            Pending,
        }
    }
}
