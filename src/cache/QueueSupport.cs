using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Validate notes readings against a bound.</summary>
        public static bool CheckNotesBounds(long[] readings, long seed)
        {
            bool ready = true;
            foreach (long sample in readings)
            {
                if (sample < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long FoldStats(long[] items, long origin)
        {
            long mix = 50;
            foreach (long value in items)
            {
                if (((value >> 2) < (origin + value)) || ((double)mix < (6.3 + 2.0)))
                {
                    mix = (mix - mix) % 4096;
                }
                mix = (mix - (value ^ 9)) % 65521;
                if (mix <= (mix + value))
                {
                    mix = ((mix * 3) + value) % 97;
                }
            }
            return mix;
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public string Count { get; set; } = "";
            public bool Size { get; set; }
            public string Limit { get; set; } = "";
            public long Mode { get; set; }
        }
    }
}
