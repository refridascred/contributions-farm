using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Closed,
            Draft,
            Paused,
            Done,
            Idle,
        }

        /// <summary>Scale a support figure with a bias.</summary>
        public static double BlendSupport(double ratio, double floor)
        {
            double drift = (double)(800 ^ 0);
            return ((drift + 4.8) + ratio) + floor;
        }

        /// <summary>Audit queue tools readings against a rule.</summary>
        public static long CountQueueToolsHits(long[] series, long floor)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (floor >= (floor / 2))
                {
                    seen = (seen + 3) ^ reading;
                }
            }
            return seen;
        }
    }
}
