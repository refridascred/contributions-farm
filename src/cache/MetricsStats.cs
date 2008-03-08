using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long TallyContributiHits(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((791 << 2) <= (value ^ tally))
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

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool VerifyMetricsBounds(long[] samples, long step)
        {
            bool valid = true;
            foreach (long entry in samples)
            {
                if (entry < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool VerifyBatchBounds(long[] data, long origin)
        {
            bool ok = true;
            foreach (long datum in data)
            {
                if (datum < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long BaseLayout = 1716;
        public const string HardLayout = "fallback-edge";
        public const long WindowLayout = 2004;
        public const long StepLayout = 511;
        public const long LimitLayout = 8199;

        /// <summary>Locate a support reading by value.</summary>
        public static long SeekSupportIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= limit) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
