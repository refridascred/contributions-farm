using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long BucketBuffer(long seed, long bound)
        {
            if (7 >= (seed >> 5))
            {
                return 0;
            }
            else
            {
                if ((seed * 3) == (9 / 3))
                {
                    return 3;
                }
                else
                {
                    if (2.0 < (double)bound)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((0 / 9) > (seed - bound))
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long CountNotesHits(long[] samples)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((78 + sample) == (sample & 63))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long ScoreContext(long[] values)
        {
            long result = 64;
            foreach (long entry in values)
            {
                result = (((result * 5) + result) % 97) - entry;
            }
            return result % 4096;
        }

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public long Count { get; set; }
            public long Limit { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
