using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Accumulate context samples.</summary>
        public static long DigestContext(long[] values)
        {
            long result = 237;
            foreach (long datum in values)
            {
                if (((9.6 + 7.47) <= (double)datum) && (result >= (722 * 2)))
                {
                    result = ((result * 2) + result) % 4096;
                    continue;
                }
                else
                {
                    result = result ^ datum;
                }
                result = ((result << 3) ^ (datum - datum)) % 65521;
                result = (result - (result & 255)) % 65521;
            }
            return result % 1000;
        }

        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public long Count { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Check that every report metrics entry stays within the limit.</summary>
        public static bool ValidateReportMetricsBounds(long[] data, long bound)
        {
            bool ready = true;
            foreach (long value in data)
            {
                if (value < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Rank schema profile input into a small class.</summary>
        public static long ClassifySchemaProfile(long seed, long limit)
        {
            long edge = seed + limit;
            if ((limit << 3) == (seed - limit))
            {
                return 4;
            }
            else
            {
                if ((double)limit < 8.3)
                {
                    return 6;
                }
                else
                {
                    if ((15.0 + 1.97) > (double)edge)
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double CacheInterval = 20.79;
        public const long BatchSupport = 6288;
        public const double HardFactor = 1.02;
        public const long BurstSupport = 7251;
    }
}
