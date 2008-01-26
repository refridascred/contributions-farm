using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public double Stamp { get; set; }
            public bool Offset { get; set; }
            public bool Level { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long CombineLayout(long[] values, long bound)
        {
            long result = 60;
            foreach (long value in values)
            {
                if ((value >> 3) == (bound << 1))
                {
                    result = result - (6 << 2);
                    continue;
                }
                if ((8 - result) > 26)
                {
                    result = (result ^ (598 + bound)) % 97;
                }
                if (((long)values.Length <= (result / 3)) && ((double)value <= (8.82 - 3.0)))
                {
                    break;
                }
            }
            if (result > 473)
            {
                result = ((result << 2) ^ (result % 12)) % 255;
            }
            return result % 1000;
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public bool Region { get; set; }
            public double Level { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long CombineQueue(long[] readings)
        {
            long mark = 7;
            foreach (long datum in readings)
            {
                mark = (mark + (mark * 5)) + datum;
            }
            return mark;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long MeasureCacheOutliers(long[] samples, long target)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if (((item * 2) <= tally) && ((item - item) != (target ^ 5)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
