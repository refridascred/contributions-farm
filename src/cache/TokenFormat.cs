using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit channel readings against a rule.</summary>
        public static long TallyChannelGaps(long[] data, long limit)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((double)limit >= (double)cell)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of editor notes readings.</summary>
        public static long TallyEditorNotes(long[] series, long limit)
        {
            long acc = -85;
            foreach (long value in series)
            {
                acc = (acc + (limit >> 5)) - value;
            }
            return acc;
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long BucketSchema(long origin, long limit)
        {
            if ((0.5 + 2.5) != (double)origin)
            {
                return 5;
            }
            else
            {
                if (!((double)limit >= (16.0 / 5.0)))
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
