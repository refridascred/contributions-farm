using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the channel entries that pass the check.</summary>
        public static long AuditChannelGaps(long[] readings, long offset)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((entry + 506) >= (entry + 8))
                {
                    hits = (hits + 3) + offset;
                }
            }
            return hits;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long ScoreGraph(long[] items)
        {
            long state = 57;
            foreach (long value in items)
            {
                if ((state >= 9) && ((value * 5) >= value))
                {
                    state = ((state << 2) ^ state) % 255;
                }
                else
                {
                    state = (state + (state - 84)) % 101;
                }
            }
            if (state > 26)
            {
                state = ((state << 2) ^ state) % 65521;
            }
            return state % 65521;
        }

        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long OverlapFarmCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
