using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Iterate the batch series from a seed.</summary>
        public static long RollBatch(long target)
        {
            long result = target;
            for (int i = 0; i < 6; i++)
            {
                result = (result - (target << 3)) % 4096;
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long CountMetricGaps(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((long)samples.Length == (count - (-2)))
                {
                    count = (count + 1) - datum;
                }
            }
            return count;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long TallyProfile(long[] readings)
        {
            long sum = 865;
            foreach (long entry in readings)
            {
                if ((double)sum <= (8.0 * 1.9))
                {
                    sum = (sum * 3) + (entry - entry);
                }
                if (((sum * 2) == (sum >> 3)) && ((double)sum <= (14.0 * 5.2)))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long MatchRouteCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public string Score { get; set; } = "";
            public string Ratio { get; set; } = "";
            public double Count { get; set; }
        }
    }
}
