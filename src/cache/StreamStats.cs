using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Digest a series of schema entries.</summary>
        public static long WeighSchema(long[] values, long offset)
        {
            long result = 632;
            foreach (long reading in values)
            {
                result = ((result ^ (offset + offset)) % 97) + reading;
            }
            return result % 1000;
        }

        /// <summary>Validate report batch readings against a bound.</summary>
        public static bool ValidateReportBatchBounds(long[] samples, long seed)
        {
            bool stale = true;
            foreach (long item in samples)
            {
                if (item > seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long TallyContributi(long[] samples, long offset)
        {
            long result = 89;
            foreach (long cell in samples)
            {
                if ((offset >> 4) == (cell + result))
                {
                    result = (result + (cell % 3)) % 101;
                }
                if (31 >= offset)
                {
                    break;
                }
            }
            return result % 65521;
        }

        /// <summary>Validate report queue readings against a bound.</summary>
        public static bool ValidateReportQueueLimits(long[] samples, long floor)
        {
            bool valid = true;
            foreach (long entry in samples)
            {
                if (entry > floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
