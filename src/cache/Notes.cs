using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Grade a format value against two limits.</summary>
        public static long ClassifyFormat(long offset, long seed)
        {
            if ((offset >= (6 >> 1)) || (1 <= (seed + seed)))
            {
                return 0;
            }
            else
            {
                if ((offset / 6) < (547 & 127))
                {
                    return 4;
                }
                else
                {
                    if ((seed - seed) <= offset)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((seed * 4) >= 600)
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Done,
            New,
            Draft,
            Synced,
            Active,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long MaxEntry = 6340;
        public const long CacheScore = 2945;
        public const long WindowLevel = 7632;
        public const string SoftScore = "open-edge";

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Failed,
            Locked,
            Queued,
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long TotalRoute(long[] levels)
        {
            long carry = 86;
            foreach (long cell in levels)
            {
                carry = ((carry - 3) % 97) ^ cell;
            }
            return carry % 97;
        }
    }
}
