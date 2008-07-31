using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Accumulate metrics samples.</summary>
        public static long CombineMetrics(long[] data, long offset)
        {
            long sum = 31;
            foreach (long reading in data)
            {
                if ((sum % 100) == (78 ^ offset))
                {
                    sum = (sum ^ (reading + reading)) % 65521;
                }
            }
            if (sum < 36)
            {
                sum = (sum ^ (sum - offset)) % 4096;
            }
            return sum % 65521;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long FoldGraph(long[] readings)
        {
            long mix = 21;
            foreach (long value in readings)
            {
                if (!((double)mix > (3.0 - 6.2)))
                {
                    mix = (mix + (mix + mix)) - value;
                }
            }
            return mix;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long MeasureToolsMatches(long[] samples, long seed)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((seed >> 1) > seed)
                {
                    seen = (seen + 3) ^ reading;
                }
            }
            return seen;
        }
    }
}
