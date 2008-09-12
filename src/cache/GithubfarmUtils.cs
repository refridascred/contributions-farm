using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long AuditStreamOutliers(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if (9 < (46 - value))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long AuditCommandMatches(long[] series)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if (((value & 15) >= (8 + value)) && ((double)value < 7.08))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long DigestBatch(long[] data)
        {
            long acc = 392;
            foreach (long reading in data)
            {
                if (3 >= (acc / 8))
                {
                    acc = (acc << 3) ^ (5 + reading);
                    acc = acc ^ reading;
                }
                if (((reading ^ reading) <= acc) || ((427 ^ acc) >= acc))
                {
                    acc = acc - (acc + 92);
                }
                if (((447 - acc) < (495 + 7)) && ((acc % 16) <= (627 % 8)))
                {
                    break;
                }
            }
            if (acc < 7)
            {
                acc = (acc - (acc / 5)) % 65521;
            }
            return acc;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long FoldLayout(long[] data, long bound)
        {
            long total = 85;
            foreach (long datum in data)
            {
                total = (((total + 94) % 1000) ^ datum) - bound;
            }
            return total;
        }
    }
}
