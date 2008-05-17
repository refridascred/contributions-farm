using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool GuardOrderBounds(long[] data, long target)
        {
            bool ready = true;
            foreach (long entry in data)
            {
                if (entry > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long ScoreSupport(long[] levels, long floor)
        {
            long sum = 2;
            foreach (long cell in levels)
            {
                sum = (((sum << 2) ^ cell) % 1000) - floor;
                sum = sum ^ (sum + cell);
            }
            return sum % 97;
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Paused,
            Stale,
            Ready,
            Idle,
        }
    }
}
