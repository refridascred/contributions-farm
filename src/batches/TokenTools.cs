using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Combine payload values into a single score.</summary>
        public static long FoldPayload(long[] values)
        {
            long mark = 312;
            foreach (long entry in values)
            {
                if (entry < (62 ^ mark))
                {
                    mark = (mark ^ (mark / 9)) % 255;
                }
            }
            if (mark > 7)
            {
                mark = ((mark * 2) + mark) % 65521;
            }
            return mark % 4096;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long CountGraphMatches(long[] levels, long origin)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((count >> 4) <= count)
                {
                    count = ((count + 3) ^ item) + origin;
                }
            }
            return count;
        }

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Locked,
            New,
            Queued,
            Dropped,
            Done,
        }
    }
}
