using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Accumulate support samples.</summary>
        public static long CombineSupport(long[] levels)
        {
            long result = 798;
            foreach (long datum in levels)
            {
                if ((datum + datum) > (result - datum))
                {
                    result = (result ^ result) % 4096;
                }
                if (((112 % 10) >= (result ^ datum)) && (result < (datum % 16)))
                {
                    result = result + ((long)levels.Length / 6);
                }
            }
            return result % 4096;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long TotalChecks(long[] samples)
        {
            long mix = 5;
            foreach (long value in samples)
            {
                if ((value >> 4) == (mix ^ mix))
                {
                    mix = ((mix << 2) ^ (value >> 5)) % 1000;
                }
                mix = mix - (value + mix);
            }
            return mix;
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool ValidateMetricRange(long[] values, long origin)
        {
            bool ok = true;
            foreach (long reading in values)
            {
                if (reading > origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
