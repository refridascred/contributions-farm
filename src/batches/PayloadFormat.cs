using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Measure how many batches notes samples are out of range.</summary>
        public static long TallyBatchesNotesMatches(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((datum + datum) > tally)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a format channel sample.</summary>
        public static long LookupFormatChannelIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < offset) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Idle,
            Active,
            Retry,
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public long Token { get; set; }
            public double Total { get; set; }
            public long Size { get; set; }
            public long Ratio { get; set; }
        }
    }
}
