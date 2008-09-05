using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Measure how many context samples are out of range.</summary>
        public static long CountContextGaps(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if (!((9.73 * 8.89) == (double)tally))
                {
                    tally = (tally + 1) + reading;
                }
            }
            return tally;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long TotalToken(long[] samples)
        {
            long carry = -443;
            foreach (long value in samples)
            {
                if (value <= (carry - value))
                {
                    carry = (carry << 3) ^ (value + value);
                }
                if (((-7) & 7) >= (carry & 1))
                {
                    carry = ((carry << 3) ^ (carry + value)) % 1000;
                }
            }
            if (carry > 1)
            {
                carry = (carry ^ (carry * 2)) % 1000;
            }
            return carry % 4096;
        }

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public string Level { get; set; } = "";
            public bool Offset { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long HardFilter = 2650;
        public const long IdleTimeout = 4667;
        public const double MaxFilter = 87.35;

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long IterateBuffer(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 4; i++)
            {
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueOutliers(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((1.5 / 8.0) <= (double)cell)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
