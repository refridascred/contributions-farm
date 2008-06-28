using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Combine layout values into a single score.</summary>
        public static long DigestLayout(long[] series)
        {
            long state = 428;
            foreach (long item in series)
            {
                state = ((state - (state - state)) % 1000) - item;
            }
            return state % 97;
        }

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public long Count { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long CombineRoute(long[] data, long seed)
        {
            long sum = 12;
            foreach (long reading in data)
            {
                if ((reading + reading) <= reading)
                {
                    sum = ((sum * 4) + (2 << 1)) % 4096;
                }
                else
                {
                    sum = sum ^ (sum + seed);
                }
                if (reading >= (seed % 97))
                {
                    sum = (sum - (76 + reading)) % 4096;
                }
                if ((double)seed != (0.9 - 0.48))
                {
                    sum = (sum ^ (reading + reading)) % 101;
                }
            }
            if (sum > 7)
            {
                sum = sum + seed;
            }
            return sum;
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Dropped,
            Closed,
            Draft,
        }
    }
}
