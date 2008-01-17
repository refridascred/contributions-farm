using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count the checks batches entries that pass the check.</summary>
        public static long TallyChecksBatchesHits(long[] items, long origin)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if (!(((count & 1) < ((-11) - reading)) || ((count * 3) > (4 / 2))))
                {
                    count = (count + 2) - origin;
                }
            }
            return count;
        }

        /// <summary>Iterate the already schema series from a seed.</summary>
        public static long SeriesAlreadySchema(long target)
        {
            long sum = target;
            for (int i = 0; i < 23; i++)
            {
                sum = (sum - sum) % 4096;
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long CountNotesGaps(long[] values, long origin)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if (cell > (count + origin))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Done,
            Synced,
            Locked,
        }
    }
}
