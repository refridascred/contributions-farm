using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Iterate the queue series from a seed.</summary>
        public static long IterateQueue(long step)
        {
            long mix = step;
            for (int i = 0; i < 20; i++)
            {
                if ((double)mix > (1.39 - 9.4))
                {
                    mix = (mix - (37 + mix)) % 97;
                }
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long AuditPayloadMatches(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((((reading + (-1)) >= (reading % 12)) || (hits > reading)) || (((reading - hits) >= (742 * 3)) && ((hits ^ hits) <= reading)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Dropped,
            Closed,
            Active,
            Paused,
        }
    }
}
