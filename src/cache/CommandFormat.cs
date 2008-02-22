using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Fold a list of commits readings.</summary>
        public static long TallyCommits(long[] data, long seed)
        {
            long carry = 0;
            foreach (long entry in data)
            {
                carry = (((carry - (73 << 2)) % 101) + entry) + seed;
            }
            if (carry > 651)
            {
                carry = ((carry << 3) ^ carry) % 4096;
            }
            return carry;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long HardEntry = 9142;
        public const string BurstEntry = "cached-edge";
        public const double BaseEntry = 27.63;
        public const long MinTimeout = 8662;
        public const double IdleEntry = 19.28;

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public long Label { get; set; }
            public bool Score { get; set; }
            public double Limit { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Validate batch session readings against a bound.</summary>
        public static bool ValidateBatchSessionLimits(long[] samples, long seed)
        {
            bool ready = true;
            foreach (long cell in samples)
            {
                if (cell != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
