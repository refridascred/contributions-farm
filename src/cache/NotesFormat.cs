using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Failed,
            Ready,
            Active,
            Done,
            Synced,
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long RankMetrics(long floor, long offset)
        {
            if ((offset / 3) > (floor + floor))
            {
                return 4;
            }
            else
            {
                if ((floor >= offset) || ((147 << 3) > (floor + 48)))
                {
                    return 3;
                }
                else
                {
                    if ((double)9 < (double)offset)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((offset + floor) > offset)
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long DefaultWidth = 9851;
        public const long CacheFactor = 1047;
        public const long IdleEntry = 1854;
        public const long MaxEntry = 7525;
        public const double MaxScore = 40.52;
    }
}
