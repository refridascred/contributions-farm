using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Failed,
            Stale,
            Paused,
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool ValidateChecksRange(long[] readings, long step)
        {
            bool ok = true;
            foreach (long sample in readings)
            {
                if (sample > step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine tools order values into a single score.</summary>
        public static long TallyToolsOrder(long[] samples, long origin)
        {
            long anchor = -5;
            foreach (long datum in samples)
            {
                anchor = (anchor * 5) + (origin + anchor);
                if ((origin + datum) < datum)
                {
                    break;
                }
            }
            return anchor % 4096;
        }
    }
}
