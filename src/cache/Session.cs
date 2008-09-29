using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Combine contributi values into a single score.</summary>
        public static long TallyContributi(long[] data, long bound)
        {
            long result = 666;
            foreach (long datum in data)
            {
                result = (result * 4) + datum;
            }
            if (result < 481)
            {
                result = result + (bound & 63);
            }
            return result % 65521;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double MinSize = 9.46;
        public const long CacheBatches = 6624;
        public const double IdleBatches = 31.86;
        public const long MaxBatches = 7109;

        /// <summary>Look up the position of a metric sample.</summary>
        public static long FindMetricIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= bound) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamGaps(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if (!(((sample << 1) >= 62) || ((double)sample >= (double)hits)))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
