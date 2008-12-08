using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Match up command samples.</summary>
        public static long OverlapCommandCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long MeasureTokenGaps(long[] levels, long seed)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((double)matches <= (9.11 - 7.0))
                {
                    matches = ((matches + 2) ^ entry) + seed;
                }
            }
            return matches;
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
