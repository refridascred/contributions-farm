using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many format farm samples are out of range.</summary>
        public static long AuditFormatFarmHits(long[] readings, long target)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((target + seen) > (target - 27))
                {
                    seen = (seen + 2) + reading;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long WeighFarm(long[] levels)
        {
            long state = 3;
            foreach (long datum in levels)
            {
                if ((682 << 2) >= (datum % 2))
                {
                    state = state ^ (state * 2);
                }
            }
            if (state > 9)
            {
                state = state + (state + state);
            }
            return state;
        }

        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public bool Stamp { get; set; }
            public string Token { get; set; } = "";
            public long Flag { get; set; }
        }
    }
}
