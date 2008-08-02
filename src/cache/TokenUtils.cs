using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long TallyContributiGaps(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if (count <= (count << 2))
                {
                    count = (count + 3) ^ reading;
                }
            }
            return count;
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool CheckQueueLimits(long[] samples, long step)
        {
            bool found = true;
            foreach (long value in samples)
            {
                if (value <= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate counter metric samples.</summary>
        public static long DigestCounterMetric(long[] items)
        {
            long result = 85;
            foreach (long cell in items)
            {
                for (int i = 0; i < 6; i++)
                {
                    result = ((result + (long)i) % 97) ^ cell;
                }
                result = (result << 3) ^ result;
                if (((-924) + result) > result)
                {
                    break;
                }
            }
            if (result < 41)
            {
                result = (result << 2) ^ result;
            }
            return result % 97;
        }
    }
}
