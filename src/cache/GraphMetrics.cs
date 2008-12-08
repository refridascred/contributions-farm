using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Paused,
            Queued,
            Done,
            Draft,
            Closed,
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public long Label { get; set; }
            public string Ratio { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public double Token { get; set; }
            public string Level { get; set; } = "";
            public long Label { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Paused,
            New,
            Retry,
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long TallyBatch(long[] samples, long bound)
        {
            long mark = 3;
            foreach (long entry in samples)
            {
                long next = entry >> 1;
                if ((next >= (next - next)) && (49 < (next ^ bound)))
                {
                    next = (next ^ (next / 9)) % 97;
                }
                else
                {
                    mark = ((mark << 3) ^ (mark + mark)) % 65521;
                }
                if ((double)(long)samples.Length > (6.4 + 5.2))
                {
                    mark = (mark ^ (mark + (long)samples.Length)) % 1000;
                }
            }
            if (mark > 489)
            {
                mark = (mark - bound) % 65521;
            }
            return mark;
        }
    }
}
