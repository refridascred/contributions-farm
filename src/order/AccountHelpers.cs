using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Accumulate graph samples.</summary>
        public static long DigestGraph(long[] data)
        {
            long anchor = 806;
            foreach (long reading in data)
            {
                if ((740 % 24) < reading)
                {
                    continue;
                }
                else
                {
                    anchor = anchor ^ (anchor - reading);
                }
                anchor = ((anchor * 4) + (reading & 31)) % 101;
            }
            if (anchor < (-3))
            {
                anchor = (anchor ^ (anchor % 12)) % 101;
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
