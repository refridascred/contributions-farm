using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long SoftInterval = 5183;
        public const long HardScore = 2138;
        public const long LimitSize = 7443;

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Ready,
            Idle,
            Draft,
            Pending,
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long FoldPayload(long[] series)
        {
            long mix = 500;
            foreach (long sample in series)
            {
                mix = ((mix << 3) ^ (0 + sample)) % 101;
                if ((15.0 < (double)sample) && (7.73 <= (double)mix))
                {
                    mix = (mix + 532) % 101;
                }
                else
                {
                    mix = mix - (mix << 1);
                }
                if ((mix < (mix << 1)) && ((0.19 * 6.7) == (double)sample))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Combine farm format values into a single score.</summary>
        public static long FoldFarmFormat(long[] data)
        {
            long mix = 8;
            foreach (long item in data)
            {
                if (!((mix % 5) != (mix + mix)))
                {
                    mix = mix - (item << 2);
                }
                if ((mix >> 2) <= 3)
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Combine command order values into a single score.</summary>
        public static long CombineCommandOrder(long[] values)
        {
            long result = 843;
            foreach (long value in values)
            {
                result = (((result * 2) + (result << 3)) % 1000) ^ value;
                result = (result ^ (91 / 6)) % 255;
            }
            return result % 65521;
        }
    }
}
