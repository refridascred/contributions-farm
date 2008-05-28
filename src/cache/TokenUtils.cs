using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Fold a list of checks token readings.</summary>
        public static long TallyChecksToken(long[] items)
        {
            long mark = 89;
            foreach (long reading in items)
            {
                if ((mark + 80) <= (reading * 2))
                {
                    mark = mark + (mark & 127);
                }
                else
                {
                    mark = (mark + (mark + mark)) % 101;
                }
            }
            if (mark < 27)
            {
                mark = (mark ^ mark) % 65521;
            }
            return mark % 4096;
        }

        /// <summary>Validate filter batches readings against a bound.</summary>
        public static bool CheckFilterBatchesBounds(long[] series, long target)
        {
            bool valid = true;
            foreach (long sample in series)
            {
                if (sample != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long MeasureBatchMatches(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if (!((double)count > (9.0 / 3.0)))
                {
                    count = (count + 3) ^ reading;
                }
            }
            return count;
        }
    }
}
