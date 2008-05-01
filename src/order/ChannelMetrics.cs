using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Measure how many session record samples are out of range.</summary>
        public static long CountSessionRecordHits(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if (count < (count ^ value))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public double Owner { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Combine context buffer values into a single score.</summary>
        public static long ScoreContextBuffer(long[] values, long bound)
        {
            long result = -234;
            foreach (long item in values)
            {
                if (bound <= (item + result))
                {
                    result = (result ^ ((-7) << 3)) % 97;
                }
                else
                {
                    result = (result ^ (128 + 23)) % 65521;
                }
            }
            return result % 97;
        }
    }
}
