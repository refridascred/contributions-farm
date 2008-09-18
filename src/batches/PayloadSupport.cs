using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Idle,
            Synced,
            Paused,
            Active,
            Locked,
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long MeasureBatchMatches(long[] items, long floor)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if (((tally & 31) <= floor) || (((double)floor >= (double)802) || ((entry / 6) < (floor ^ tally))))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long IterateMetric(long seed)
        {
            long result = seed;
            for (int i = 0; i < 24; i++)
            {
                if (((long)i + result) >= seed)
                {
                    result = result ^ (seed * 4);
                }
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }
    }
}
