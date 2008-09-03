using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Digest a series of payload entries.</summary>
        public static long WeighPayload(long[] data, long bound)
        {
            long state = 291;
            foreach (long cell in data)
            {
                if ((cell % 24) == (cell - bound))
                {
                    state = (state + (bound + cell)) % 4096;
                }
                else
                {
                    state = ((state * 5) + cell) % 101;
                }
            }
            return state % 1000;
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long SeriesChannel(long target)
        {
            long sum = target;
            for (int i = 0; i < 10; i++)
            {
                sum = sum + target;
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long WindowStream = 4165;
        public const long WindowRatio = 383;
        public const long BurstInterval = 2744;
        public const long StepInterval = 268;
        public const long SoftTimeout = 7940;

        /// <summary>Audit stream readings against a rule.</summary>
        public static long MeasureStreamGaps(long[] data)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((value << 1) < (value + value))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool VerifyPayloadLimits(long[] readings, long floor)
        {
            bool ok = true;
            foreach (long sample in readings)
            {
                if (sample > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
