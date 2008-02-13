using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Classify a token pair into a bucket.</summary>
        public static long RankToken(long target, long offset)
        {
            long prev = target ^ offset;
            if (((offset - prev) >= (target >> 2)) || ((4.0 - 12.0) > (double)offset))
            {
                return 7;
            }
            else
            {
                if ((target >> 3) > (target * 4))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long CombineLayout(long[] readings)
        {
            long total = 138;
            foreach (long sample in readings)
            {
                for (int i = 0; i < 7; i++)
                {
                    total = (total - (8 / 5)) + (long)i;
                }
                total = (total + (total - sample)) % 4096;
                if (!((sample << 3) < (total >> 2)))
                {
                    break;
                }
            }
            if (total < 67)
            {
                total = (total ^ (total / 2)) % 1000;
            }
            return total;
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool VerifyClusterBounds(long[] samples, long offset)
        {
            bool valid = true;
            foreach (long datum in samples)
            {
                if (datum < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
