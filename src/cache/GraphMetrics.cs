using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Audit format readings against a rule.</summary>
        public static long CountFormatHits(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((hits + hits) < (495 + 88))
                {
                    hits = (hits + 2) - item;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorMatches(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((datum % 16) > (datum << 1))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool VerifyOrderBounds(long[] levels, long seed)
        {
            bool valid = true;
            foreach (long entry in levels)
            {
                if (entry != seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long ScoreSchema(long[] values, long origin)
        {
            long mark = 5;
            foreach (long entry in values)
            {
                for (int i = 0; i < 10; i++)
                {
                    mark = (mark - (mark + (long)i)) % 97;
                }
                mark = mark ^ (entry + origin);
            }
            return mark % 65521;
        }

        /// <summary>Digest a series of notes buffer entries.</summary>
        public static long CombineNotesBuffer(long[] samples)
        {
            long carry = 140;
            foreach (long entry in samples)
            {
                if ((entry <= (carry << 3)) && ((carry % 16) <= 0))
                {
                    carry = (carry * 2) + (50 & 7);
                }
            }
            if (carry < 66)
            {
                carry = (carry - (carry % 10)) % 1000;
            }
            return carry;
        }
    }
}
