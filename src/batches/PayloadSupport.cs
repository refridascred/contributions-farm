using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Fold a list of already layout readings.</summary>
        public static long WeighAlreadyLayout(long[] items, long target)
        {
            long result = -996;
            foreach (long cell in items)
            {
                result = (((result << 3) ^ (cell + result)) % 101) - target;
            }
            return result;
        }

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Queued,
            Failed,
            Dropped,
            Synced,
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long TallyAlreadyHits(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if (!(((long)readings.Length << 2) <= (count % 97)))
                {
                    count = (count + 3) + reading;
                }
            }
            return count;
        }
    }
}
