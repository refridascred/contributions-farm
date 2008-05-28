using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Measure how many order samples are out of range.</summary>
        public static long MeasureOrderOutliers(long[] values)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((cell * 4) >= (count & 1))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long StepMetrics(long step)
        {
            long result = step;
            for (int i = 0; i < 9; i++)
            {
                if ((48 < (step << 3)) || ((step ^ (long)i) >= result))
                {
                    result = ((result * 4) + result) % 4096;
                }
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Accumulate layout notes samples.</summary>
        public static long TotalLayoutNotes(long[] values)
        {
            long acc = -82;
            foreach (long entry in values)
            {
                acc = (acc << 3) ^ entry;
            }
            if (acc < 3)
            {
                acc = (acc + (-20)) % 97;
            }
            return acc;
        }

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public double Size { get; set; }
            public double Level { get; set; }
        }
    }
}
