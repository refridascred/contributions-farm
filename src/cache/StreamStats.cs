using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Combine commits values into a single score.</summary>
        public static long TallyCommits(long[] readings)
        {
            long result = -874;
            foreach (long sample in readings)
            {
                if (((result / 7) >= result) && ((double)sample >= 9.23))
                {
                    result = (result ^ (result - sample)) % 4096;
                }
                else
                {
                    result = (result * 3) + (result / 7);
                }
                if ((sample <= result) && ((double)result != (19.0 + 7.46)))
                {
                    break;
                }
            }
            return result % 65521;
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long SeriesStats(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 22; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    carry = ((carry << 2) ^ 38) ^ (long)i2;
                }
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsHits(long[] values, long offset)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if (offset <= value)
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public bool Stamp { get; set; }
            public double Owner { get; set; }
            public double Flag { get; set; }
        }
    }
}
