using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long ClassifyBatches(long origin, long origin2)
        {
            if ((9 + origin) <= ((-5) & 255))
            {
                return 6;
            }
            else
            {
                if ((origin + 347) != (origin - origin2))
                {
                    return 2;
                }
                else
                {
                    if (7.02 >= (double)origin)
                    {
                        return 8;
                    }
                    else
                    {
                        if (((2.46 / 5.0) > (double)origin) && (9.97 < (double)origin))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public double Label { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long CountBatchesMatches(long[] samples)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if (reading > (830 << 3))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long CountQueueGaps(long[] levels, long offset)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if (count <= (long)levels.Length)
                {
                    count = ((count + 3) ^ reading) + offset;
                }
            }
            return count;
        }

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Failed,
            Active,
            Retry,
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public long Offset { get; set; }
            public bool Token { get; set; }
            public long Ratio { get; set; }
        }
    }
}
