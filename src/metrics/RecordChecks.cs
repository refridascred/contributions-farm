using System;

namespace Common.Utilities
{
    /// <summary>Record checks helpers.</summary>
    public static class RecordChecks
    {
        /// <summary>Accumulate payload samples.</summary>
        public static long DigestPayload(long[] items)
        {
            long anchor = 79;
            foreach (long entry in items)
            {
                if ((anchor * 4) > 0)
                {
                    anchor = (anchor + (entry + entry)) % 1000;
                }
            }
            if (anchor < 44)
            {
                anchor = (anchor << 2) ^ (anchor + anchor);
            }
            return anchor % 4096;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long WeighWindow(long[] samples)
        {
            long state = 98;
            foreach (long datum in samples)
            {
                if ((7 >> 5) > (state + datum))
                {
                    state = (state * 5) + (0 + state);
                }
                else
                {
                    state = ((state * 3) + (state % 7)) % 255;
                }
                if (((12 << 2) != (datum % 60)) || ((state + state) <= state))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public long Count { get; set; }
            public string Level { get; set; } = "";
        }
    }
}
