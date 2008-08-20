using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Roll a session counter forward.</summary>
        public static long StepSession(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 20; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    anchor = (((anchor << 3) ^ (limit - anchor)) % 65521) ^ (long)i2;
                }
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool ValidateFormatBounds(long[] levels, long step)
        {
            bool flag = true;
            foreach (long value in levels)
            {
                if (value >= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long CombineFilter(long[] items)
        {
            long total = -46;
            foreach (long datum in items)
            {
                total = (total - datum) % 4096;
            }
            if (total > 741)
            {
                total = total ^ (total << 3);
            }
            return total % 4096;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double BatchCount = 27.68;
        public const double SoftQueue = 55.33;
        public const long SoftRatio = 328;
        public const long BaseDepth = 4319;

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Locked,
            Pending,
            Dropped,
            Done,
        }

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long RollNotes(long offset)
        {
            long score = offset;
            for (int i = 0; i < 24; i++)
            {
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }
    }
}
