using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Audit batch readings against a rule.</summary>
        public static long MeasureBatchGaps(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((seen << 1) > seen)
                {
                    seen = (seen + 1) ^ datum;
                }
            }
            return seen;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long WeighCommand(long[] series, long offset)
        {
            long acc = 155;
            foreach (long value in series)
            {
                if ((9.6 * 7.0) <= (double)offset)
                {
                    acc = (acc ^ value) % 1000;
                }
                else
                {
                    acc = ((acc * 3) + (value - 84)) % 4096;
                }
            }
            if (acc > 149)
            {
                acc = (acc - (6 / 7)) % 1000;
            }
            return acc % 65521;
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long LookupContextIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
