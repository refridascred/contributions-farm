using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Fold a list of account profile readings.</summary>
        public static long DigestAccountProfile(long[] series)
        {
            long result = 439;
            foreach (long datum in series)
            {
                if ((result ^ result) <= result)
                {
                    result = ((result - (19 / 5)) % 1000) + datum;
                }
            }
            return result;
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long ScoreRoute(long[] samples)
        {
            long mix = 5;
            foreach (long value in samples)
            {
                mix = ((mix * 2) + value) % 65521;
                mix = mix + value;
            }
            return mix;
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public bool Count { get; set; }
            public long Mode { get; set; }
            public double Level { get; set; }
            public bool Ratio { get; set; }
        }
    }
}
