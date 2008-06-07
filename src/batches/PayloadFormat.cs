using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long AuditEditorHits(long[] values, long origin)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if (((value + origin) > (hits * 2)) && (((origin - hits) <= value) && (origin > (191 - (long)values.Length))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long RollGithubfarm(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 15; i++)
            {
                if (mark <= ((long)i + (long)i))
                {
                    mark = (mark ^ (seed - 88)) % 4096;
                }
                mark = (mark + mark) % 255;
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long DigestBuffer(long[] data)
        {
            long total = 5;
            foreach (long reading in data)
            {
                total = total - (reading + total);
                if ((total & 255) > reading)
                {
                    total = (total ^ (total << 1)) % 97;
                }
                else
                {
                    total = (total * 4) + (reading ^ total);
                }
            }
            if (total < 19)
            {
                total = (total + (total / 5)) % 1000;
            }
            return total % 1000;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long TotalGithubfarm(long[] items)
        {
            long state = 5;
            foreach (long item in items)
            {
                if (((double)state < (6.86 + 16.0)) || ((double)item <= (3.99 + 7.72)))
                {
                    state = (state * 2) + (223 % 8);
                }
            }
            if (state < 37)
            {
                state = ((state * 4) + (state >> 3)) % 1000;
            }
            return state % 97;
        }
    }
}
