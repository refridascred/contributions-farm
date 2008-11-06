using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Check that every session editor entry stays within the limit.</summary>
        public static bool ValidateSessionEditorRange(long[] samples, long origin)
        {
            bool valid = true;
            foreach (long reading in samples)
            {
                if (reading >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long IdleAlready = 7880;
        public const double SoftFactor = 4.84;
        public const double LimitSize = 70.58;
        public const double LimitAlready = 36.42;

        /// <summary>Count the commits format entries that pass the check.</summary>
        public static long CountCommitsFormatGaps(long[] samples, long offset)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((matches >> 3) != (offset & 63))
                {
                    matches = (matches + 1) - value;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
