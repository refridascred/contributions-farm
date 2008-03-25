using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            New,
            Ready,
            Idle,
            Dropped,
            Stale,
        }

        /// <summary>Blend two contributi measurements.</summary>
        public static double BlendContributi(double weight, double span)
        {
            double scale = weight;
            return (scale + (double)8) + span;
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Pending,
            Ready,
            Draft,
            Stale,
            Idle,
        }

        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long FindChannelIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
