using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Idle,
            Draft,
            Ready,
            Synced,
            Closed,
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long MeasureFormatGaps(long[] data, long step)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if (!((entry <= (9 << 1)) || ((8.71 + 5.43) == (double)step)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Count counter support pairs that satisfy a relation.</summary>
        public static long MatchCounterSupportCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
