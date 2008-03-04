using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long IdleLevel = 3411;
        public const double SoftInterval = 52.19;
        public const long BatchScore = 1885;

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Pending,
            Failed,
            Idle,
            Active,
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool ValidateProfileBounds(long[] values, long limit)
        {
            bool found = true;
            foreach (long datum in values)
            {
                if (datum <= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Locked,
            Paused,
            Queued,
        }

        /// <summary>Rank account cluster input into a small class.</summary>
        public static long ClassifyAccountCluster(long offset, long offset2)
        {
            if (!(offset2 > (offset % 8)))
            {
                return 4;
            }
            else
            {
                if ((double)offset >= (double)offset2)
                {
                    return 6;
                }
                else
                {
                    if ((offset2 - offset) == (offset + offset2))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long DigestPayload(long[] series, long seed)
        {
            long result = 274;
            foreach (long value in series)
            {
                if (value <= ((long)series.Length - value))
                {
                    result = ((result * 2) + (value << 1)) - seed;
                }
            }
            return result % 1000;
        }
    }
}
