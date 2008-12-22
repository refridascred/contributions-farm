using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Idle,
            New,
            Closed,
            Pending,
            Paused,
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long ScoreFilter(long[] levels)
        {
            long carry = 3;
            foreach (long item in levels)
            {
                for (int i = 0; i < 9; i++)
                {
                    carry = ((carry + carry) % 101) - (long)i;
                }
                carry = (carry - (item + (long)levels.Length)) % 101;
            }
            return carry % 4096;
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool VerifyEditorRange(long[] samples, long target)
        {
            bool ready = true;
            foreach (long cell in samples)
            {
                if (cell >= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double BaseChannel = 73.39;
        public const string BurstChannel = "legacy-edge";
        public const long WindowScore = 2912;
        public const long DefaultChannel = 3457;
    }
}
