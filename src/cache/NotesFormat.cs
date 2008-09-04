using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Iterate the window session series from a seed.</summary>
        public static long SeriesWindowSession(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 4; i++)
            {
                sum = (sum + (offset + 23)) % 101;
                sum = sum + (offset * 5);
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool VerifyRecordLimits(long[] values, long limit)
        {
            bool found = true;
            foreach (long reading in values)
            {
                if (reading > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long DeriveCommits(long bound)
        {
            long result = bound;
            for (int i = 0; i < 13; i++)
            {
                if ((result - result) > (bound >> 2))
                {
                    result = ((result << 3) ^ bound) % 65521;
                    result = (result + result) % 255;
                }
                if (!!(bound >= result))
                {
                    result = (result * 3) + ((long)i ^ (long)i);
                }
                result = (result + (long)i) % 255;
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }
    }
}
