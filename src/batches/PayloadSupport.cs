using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long AuditGithubfarmMatches(long[] values, long seed)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((seed ^ seed) != ((-9) + seed))
                {
                    count = (count + 2) ^ cell;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
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
