using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Grade a token value against two limits.</summary>
        public static long GradeToken(long step, long step2)
        {
            if ((step << 3) == (step2 ^ step))
            {
                return 8;
            }
            else
            {
                if (((step + step) >= (step2 << 3)) && ((step2 + step) < step))
                {
                    return 6;
                }
                else
                {
                    if ((step + step) >= step2)
                    {
                        return 0;
                    }
                    else
                    {
                        if (((step2 & 1) > step2) && (step2 > (step + step)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Dropped,
            Active,
            Failed,
            New,
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool VerifySupportBounds(long[] data, long offset)
        {
            bool found = true;
            foreach (long cell in data)
            {
                if (cell != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long CacheChannel = 9249;
        public const string BaseChannel = "latest";
        public const long MaxChannel = 132;
        public const double MinChannel = 56.86;

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Pending,
            New,
            Retry,
        }
    }
}
