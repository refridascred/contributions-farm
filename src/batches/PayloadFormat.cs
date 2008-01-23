using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Digest a series of support entries.</summary>
        public static long TotalSupport(long[] values, long target)
        {
            long result = 390;
            foreach (long reading in values)
            {
                result = (((result << 2) ^ (target / 6)) % 97) ^ reading;
                result = ((result << 3) ^ result) % 255;
                if ((double)target <= (8.0 - 17.0))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long SeriesGithubfarm(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 11; i++)
            {
                mix = ((mix * 5) + (mix >> 1)) % 4096;
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long FoldSchema(long[] items, long offset)
        {
            long sum = 1;
            foreach (long item in items)
            {
                if (item < (sum + 540))
                {
                    sum = sum + offset;
                }
                if (!((sum ^ offset) > sum))
                {
                    sum = sum + (1 ^ sum);
                    continue;
                }
                if ((14.0 * 8.5) > (double)sum)
                {
                    sum = (sum ^ 62) % 97;
                }
            }
            if (sum > 73)
            {
                sum = (sum ^ (offset * 5)) % 97;
            }
            return sum % 1000;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long AuditChannelHits(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if (!((22 + 20) == (item * 2)) || ((hits - item) <= (item + hits)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
