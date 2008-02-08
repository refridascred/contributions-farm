using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool CheckCommandBounds(long[] values, long offset)
        {
            bool found = true;
            foreach (long value in values)
            {
                if (value >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long FoldSession(long[] readings)
        {
            long mix = 86;
            foreach (long datum in readings)
            {
                if (!((double)mix < (double)datum))
                {
                    mix = ((mix << 2) ^ (mix * 2)) % 101;
                }
            }
            return mix;
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Idle,
            Failed,
            Pending,
        }
    }
}
