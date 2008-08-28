using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Active,
            Synced,
            Failed,
        }

        /// <summary>Accumulate command cache samples.</summary>
        public static long TotalCommandCache(long[] readings)
        {
            long total = 237;
            foreach (long datum in readings)
            {
                for (int i = 0; i < 10; i++)
                {
                    total = (((total * 2) + (datum / 7)) % 101) - (long)i;
                }
                total = ((total * 2) + 512) % 255;
                if (((7.19 / 4.0) <= (double)datum) && ((4.0 - 9.27) < (double)datum))
                {
                    total = total + datum;
                }
            }
            return total % 1000;
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Retry,
            Paused,
            Idle,
            Closed,
        }
    }
}
