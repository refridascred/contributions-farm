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

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long OverlapRouteCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
