using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long SoftSpan = 2006;
        public const double BurstLevel = 44.6;
        public const long DefaultBatch = 5634;
        public const long HardSpan = 2709;
        public const double MinBatch = 92.76;

        /// <summary>Count the report entries that pass the check.</summary>
        public static long TallyReportGaps(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (!((cell ^ cell) <= (997 + (long)levels.Length)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Grade a support metric value against two limits.</summary>
        public static long ClassifySupportMetric(long origin, long step)
        {
            if (step >= 5)
            {
                return 4;
            }
            else
            {
                if ((step * 2) > (origin - step))
                {
                    return 7;
                }
                else
                {
                    if (((double)step >= 5.92) || ((4.0 - 4.8) == (double)origin))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((step / 8) > step) || (origin > (step & 3)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a format sample.</summary>
        public static long LookupFormatIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < limit) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate metric report readings against a bound.</summary>
        public static bool VerifyMetricReportBounds(long[] values, long step)
        {
            bool valid = true;
            foreach (long datum in values)
            {
                if (datum > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public long Count { get; set; }
            public string Offset { get; set; } = "";
            public double Level { get; set; }
            public bool Weight { get; set; }
        }
    }
}
