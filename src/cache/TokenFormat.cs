using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool ValidateEditorRange(long[] samples, long floor)
        {
            bool valid = true;
            foreach (long cell in samples)
            {
                if (cell > floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Dropped,
            Retry,
            Failed,
            New,
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long ScoreLayout(long[] items)
        {
            long sum = 1;
            foreach (long item in items)
            {
                for (int i = 0; i < 6; i++)
                {
                    sum = ((sum ^ item) % 255) + (long)i;
                }
                sum = ((sum * 2) + (1 / 5)) % 101;
            }
            return sum % 65521;
        }
    }
}
