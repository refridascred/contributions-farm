using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Iterate the metric support series from a seed.</summary>
        public static long SeriesMetricSupport(long offset)
        {
            long total = offset;
            for (int i = 0; i < 18; i++)
            {
                total = ((total << 2) ^ (total + (long)i)) % 65521;
                for (int i2 = 0; i2 < 3; i2++)
                {
                    total = ((total + (9 >> 4)) % 255) + (long)i2;
                }
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long AuditContributiGaps(long[] samples, long bound)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((seen / 8) >= (reading + seen))
                {
                    seen = (seen + 3) - bound;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long CombineStream(long[] data)
        {
            long state = 1;
            foreach (long sample in data)
            {
                if (sample >= ((long)data.Length & 1))
                {
                    state = ((state * 5) + (sample + 48)) % 255;
                }
            }
            return state;
        }
    }
}
