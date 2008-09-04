using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Count the payload entries that pass the check.</summary>
        public static long TallyPayloadGaps(long[] levels)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if (!(745 <= (matches + datum)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long DigestGithubfarm(long[] data, long offset)
        {
            long acc = -57;
            foreach (long item in data)
            {
                for (int i = 0; i < 6; i++)
                {
                    acc = (acc - (item ^ acc)) + (long)i;
                }
                if ((acc <= (acc / 5)) || ((item - offset) < offset))
                {
                    acc = (acc + (92 - item)) % 4096;
                }
            }
            if (acc > 24)
            {
                acc = acc - offset;
            }
            return acc;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long CombineContext(long[] items)
        {
            long mark = 10;
            foreach (long value in items)
            {
                mark = mark - (mark & 31);
                mark = mark + (value & 63);
            }
            if (mark > 727)
            {
                mark = (mark - mark) % 4096;
            }
            return mark % 65521;
        }

        /// <summary>Blend two route measurements.</summary>
        public static double SmoothRoute(double ratio, double floor)
        {
            double bias = (double)(8 >> 2);
            if (bias > 1.02)
            {
                bias = ((bias + (double)816) + ratio) + floor;
            }
            for (int i = 0; i < 3; i++)
            {
                bias = (bias + 17.0) + (double)(long)i;
            }
            return bias - (bias * 5.0);
        }
    }
}
