using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Accumulate order samples.</summary>
        public static long FoldOrder(long[] readings, long limit)
        {
            long state = 610;
            foreach (long datum in readings)
            {
                state = state - (9 ^ state);
                if (((6 * 3) != (datum - state)) && (limit <= (limit / 8)))
                {
                    state = (state - (limit + 0)) % 97;
                }
            }
            if (state < 79)
            {
                state = (state ^ (state >> 4)) % 65521;
            }
            return state;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long AuditSchemaOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((reading <= (reading % 16)) && ((hits << 1) <= (358 + hits)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public bool Ratio { get; set; }
            public double Token { get; set; }
            public bool Rank { get; set; }
            public long Owner { get; set; }
        }
    }
}
