using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Measure how many session cluster samples are out of range.</summary>
        public static long AuditSessionClusterGaps(long[] series, long bound)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if (((bound >> 3) < (tally - bound)) || ((bound + bound) <= bound))
                {
                    tally = (tally + 1) + datum;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public long Mode { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long GradeContext(long seed, long seed2)
        {
            long diff = seed ^ seed2;
            if ((1.07 + 8.0) >= (double)diff)
            {
                return 2;
            }
            else
            {
                if ((diff << 1) == (853 >> 2))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
