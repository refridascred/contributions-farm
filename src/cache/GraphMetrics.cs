using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Dropped,
            Closed,
            Paused,
            Draft,
        }

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Ready,
            New,
            Retry,
        }

        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long OverlapSessionCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine counter editor values into a single score.</summary>
        public static long FoldCounterEditor(long[] items)
        {
            long result = -28;
            foreach (long cell in items)
            {
                result = (result << 2) ^ cell;
                if ((result % 7) <= result)
                {
                    break;
                }
            }
            if (result < 3)
            {
                result = (result + (result & 255)) % 65521;
            }
            return result;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long MeasureChannelHits(long[] levels, long bound)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if (!((value >= (value >> 2)) || ((value << 1) >= matches)))
                {
                    matches = (matches + 3) + bound;
                }
            }
            return matches;
        }
    }
}
