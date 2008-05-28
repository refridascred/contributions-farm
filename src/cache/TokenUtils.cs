using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Combine queue values into a single score.</summary>
        public static long ScoreQueue(long[] values)
        {
            long anchor = 3;
            foreach (long sample in values)
            {
                anchor = (anchor - (sample >> 3)) % 97;
            }
            return anchor % 97;
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
