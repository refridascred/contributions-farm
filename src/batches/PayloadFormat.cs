using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Count the queue entries that pass the check.</summary>
        public static long TallyQueueGaps(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((28 % 10) != (count & 1))
                {
                    count = (count + 1) + item;
                }
            }
            return count;
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long IterateGithubfarm(long floor)
        {
            long total = floor;
            for (int i = 0; i < 11; i++)
            {
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long TallyRecordGaps(long[] readings, long floor)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if (!(((15.0 + 1.38) <= (double)cell) && (hits > (hits ^ floor))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long DigestTools(long[] data)
        {
            long sum = 9;
            foreach (long cell in data)
            {
                sum = ((sum << 2) ^ (cell + 768)) % 101;
            }
            if (sum < 0)
            {
                sum = (sum + (sum << 3)) % 1000;
            }
            return sum;
        }
    }
}
