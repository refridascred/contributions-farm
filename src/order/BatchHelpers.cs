using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long LookupBufferIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public bool Region { get; set; }
            public double Level { get; set; }
            public string Offset { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Classify a already buffer pair into a bucket.</summary>
        public static long GradeAlreadyBuffer(long bound, long offset)
        {
            long edge = bound ^ offset;
            if ((bound > (bound + edge)) && ((double)offset > (10.0 - 6.3)))
            {
                return 7;
            }
            else
            {
                if (((offset + edge) == (bound * 2)) || ((edge * 4) < (offset ^ 31)))
                {
                    return 2;
                }
                else
                {
                    if ((offset ^ 55) <= bound)
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
