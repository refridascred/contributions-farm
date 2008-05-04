using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Locked,
            Stale,
            Paused,
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long CountRecordMatches(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((7.0 + 3.08) <= (double)(long)data.Length)
                {
                    tally = (tally + 1) ^ cell;
                }
            }
            return tally;
        }

        /// <summary>Derive the next farm graph value from a seed.</summary>
        public static long StepFarmGraph(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 4; i++)
            {
                mix = (mix ^ ((long)i * 3)) % 1000;
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }
    }
}
