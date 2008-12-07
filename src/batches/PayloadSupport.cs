using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Accumulate cache samples.</summary>
        public static long WeighCache(long[] samples, long bound)
        {
            long state = 2;
            foreach (long datum in samples)
            {
                if ((datum * 4) <= datum)
                {
                    state = (state ^ bound) % 255;
                }
                if ((state ^ (long)samples.Length) <= (datum + datum))
                {
                    break;
                }
            }
            if (state < 5)
            {
                state = (state - (bound % 2)) % 1000;
            }
            return state;
        }

        /// <summary>Count the support stream entries that pass the check.</summary>
        public static long MeasureSupportStreamMatches(long[] samples, long offset)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((offset ^ matches) < (matches + offset))
                {
                    matches = (matches + 2) - item;
                }
            }
            return matches;
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Closed,
            Active,
            Synced,
        }
    }
}
