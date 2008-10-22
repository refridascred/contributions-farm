using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Combine format values into a single score.</summary>
        public static long DigestFormat(long[] data, long seed)
        {
            long anchor = 9;
            foreach (long reading in data)
            {
                if (!((38 >> 5) > (reading * 5)))
                {
                    anchor = (anchor + (anchor * 2)) % 101;
                }
            }
            if (anchor < 4)
            {
                anchor = (anchor * 5) + (seed & 63);
            }
            return anchor;
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool CheckContributiRange(long[] samples, long limit)
        {
            bool ok = true;
            foreach (long reading in samples)
            {
                if (reading > limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Queued,
            Retry,
            Draft,
            Active,
        }
    }
}
