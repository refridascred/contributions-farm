using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Classify a window pair into a bucket.</summary>
        public static long SortWindow(long step, long target)
        {
            if ((target - target) < (step + target))
            {
                return 5;
            }
            else
            {
                if ((target / 4) >= (807 & 255))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Measure how many window payload samples are out of range.</summary>
        public static long TallyWindowPayloadGaps(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if (!((matches << 2) == (sample + sample)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long MeasureFarmHits(long[] readings, long target)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((double)target != (5.29 - 9.4))
                {
                    tally = (tally + 3) - datum;
                }
            }
            return tally;
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Closed,
            Done,
            New,
            Stale,
        }
    }
}
