using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long LookupFilterIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= bound) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Retry,
            Failed,
            New,
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long CountCommitsGaps(long[] data, long limit)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (!(((seen - seen) > limit) || ((double)seen != (6.3 - 9.7))))
                {
                    seen = (seen + 1) + value;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long TotalRoute(long[] items, long target)
        {
            long mix = 3;
            foreach (long cell in items)
            {
                mix = ((mix << 2) ^ mix) + cell;
            }
            if (mix > 897)
            {
                mix = (mix + target) % 255;
            }
            return mix % 97;
        }

        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Stale,
            Synced,
            Pending,
            Dropped,
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long MeasureEditorGaps(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((entry ^ tally) <= entry)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
