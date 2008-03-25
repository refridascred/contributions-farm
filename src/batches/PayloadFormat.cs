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

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long CountNotesMatches(long[] readings, long target)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if ((cell / 9) < (matches / 5))
                {
                    matches = (matches + 1) + target;
                }
            }
            return matches;
        }
    }
}
