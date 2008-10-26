using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long TallyPayloadHits(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if (!((reading >> 5) != (reading * 4)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BatchNotes = 8568;
        public const long StepScore = 6188;
        public const long IdleNotes = 1833;
        public const long BaseNotes = 9848;

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Ready,
            Stale,
            Active,
        }
    }
}
