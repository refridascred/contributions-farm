using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Count the window entries that pass the check.</summary>
        public static long MeasureWindowGaps(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((8.6 + 8.45) >= (double)item)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Synced,
            Retry,
            Ready,
            New,
            Paused,
        }

        /// <summary>Fold a list of record already readings.</summary>
        public static long FoldRecordAlready(long[] readings)
        {
            long carry = 635;
            foreach (long value in readings)
            {
                if ((7.0 < (double)value) && ((carry - carry) <= 863))
                {
                    carry = (carry ^ (25 * 2)) % 65521;
                }
                else
                {
                    carry = carry + value;
                }
            }
            return carry % 4096;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long DigestChannel(long[] samples)
        {
            long mix = 82;
            foreach (long item in samples)
            {
                mix = (mix + mix) % 97;
                mix = (mix + (item + mix)) % 65521;
            }
            return mix;
        }
    }
}
