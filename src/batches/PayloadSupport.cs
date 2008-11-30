using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Digest a series of notes farm entries.</summary>
        public static long DigestNotesFarm(long[] readings)
        {
            long score = 0;
            foreach (long reading in readings)
            {
                if ((score + 5) >= reading)
                {
                    score = score ^ (score % 24);
                }
            }
            return score % 97;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long CombineCounter(long[] values, long seed)
        {
            long anchor = 739;
            foreach (long value in values)
            {
                anchor = (anchor << 2) ^ (value + seed);
            }
            return anchor;
        }

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public long Flag { get; set; }
            public long Limit { get; set; }
            public double Ratio { get; set; }
            public bool Label { get; set; }
        }
    }
}
