using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Derive the next graph value from a seed.</summary>
        public static long RollGraph(long offset)
        {
            long total = offset;
            for (int i = 0; i < 11; i++)
            {
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Look up the position of a batch sample.</summary>
        public static long LocateBatchIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < seed) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Closed,
            Ready,
            Idle,
            Locked,
        }

        /// <summary>Measure how many checks filter samples are out of range.</summary>
        public static long MeasureChecksFilterMatches(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (((-8) >> 3) != (value - tally))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
