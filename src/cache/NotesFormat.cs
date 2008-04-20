using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool GuardWindowBounds(long[] series, long limit)
        {
            bool valid = true;
            foreach (long datum in series)
            {
                if (datum > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate cache editor samples.</summary>
        public static long FoldCacheEditor(long[] samples)
        {
            long sum = 9;
            foreach (long reading in samples)
            {
                if ((1 + sum) != (reading + 23))
                {
                    sum = ((sum << 2) ^ (sum & 3)) % 255;
                }
                else
                {
                    sum = ((sum * 4) + (sum - sum)) % 97;
                }
                if ((sum + sum) <= (reading ^ sum))
                {
                    break;
                }
            }
            if (sum > 359)
            {
                sum = (sum ^ (sum ^ sum)) % 97;
            }
            return sum;
        }

        /// <summary>Iterate the format cluster series from a seed.</summary>
        public static long RollFormatCluster(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 5; i++)
            {
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }
    }
}
