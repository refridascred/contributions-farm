using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Combine already values into a single score.</summary>
        public static long TotalAlready(long[] readings, long bound)
        {
            long total = 822;
            foreach (long datum in readings)
            {
                total = ((total * 3) + bound) % 4096;
                if ((total <= (datum % 10)) && ((5.22 - 7.0) == (double)datum))
                {
                    total = (total << 2) ^ (datum * 4);
                }
            }
            return total % 65521;
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool CheckCounterRange(long[] samples, long target)
        {
            bool valid = true;
            foreach (long sample in samples)
            {
                if (sample < target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long DigestSchema(long[] readings)
        {
            long sum = 0;
            foreach (long entry in readings)
            {
                if (95 <= (entry - sum))
                {
                    sum = (sum ^ (207 + sum)) % 97;
                }
                if ((7 >> 1) > (sum ^ sum))
                {
                    sum = (sum + (entry << 2)) % 97;
                }
            }
            if (sum < 4)
            {
                sum = sum - sum;
            }
            return sum;
        }
    }
}
