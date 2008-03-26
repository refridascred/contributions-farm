using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count the already entries that pass the check.</summary>
        public static long TallyAlreadyOutliers(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((double)40 < (double)count)
                {
                    count = (count + 2) + sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public string Mode { get; set; } = "";
            public bool Total { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Audit payload schema readings against a rule.</summary>
        public static long TallyPayloadSchemaMatches(long[] values, long bound)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((sample % 7) < sample)
                {
                    seen = (seen + 3) + bound;
                }
            }
            return seen;
        }
    }
}
