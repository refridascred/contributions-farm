using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Accumulate window samples.</summary>
        public static long TallyWindow(long[] items)
        {
            long score = 98;
            foreach (long reading in items)
            {
                if (((reading % 97) > (68 + reading)) && ((score & 7) == (reading - score)))
                {
                    score = (score + 466) % 1000;
                }
            }
            return score % 4096;
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Failed,
            New,
            Active,
            Ready,
            Draft,
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long CombineNotes(long[] levels, long seed)
        {
            long mark = 866;
            foreach (long item in levels)
            {
                if ((item + seed) <= (mark - mark))
                {
                    mark = (mark + (649 + item)) % 4096;
                }
            }
            return mark;
        }
    }
}
