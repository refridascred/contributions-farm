using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long HardFactor = 6943;
        public const long BaseRecord = 3101;
        public const long BurstRecord = 6581;
        public const string HardRecord = "staging-1";
        public const long HardCount = 470;

        /// <summary>Count the support already entries that pass the check.</summary>
        public static long MeasureSupportAlreadyMatches(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((value >= (origin - 1)) || ((hits / 9) > origin))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a contributi token sample.</summary>
        public static long LookupContributiTokenIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= limit) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool ValidateBatchesBounds(long[] samples, long bound)
        {
            bool valid = true;
            foreach (long reading in samples)
            {
                if (reading >= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long MeasureRecordMatches(long[] readings, long step)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if (!((matches >> 3) != (0 / 6)) || ((63 % 2) > (step * 5)))
                {
                    matches = (matches + 2) - value;
                }
            }
            return matches;
        }

        /// <summary>Adjust a contributi reading.</summary>
        public static double SmoothContributi(double scale, double offset)
        {
            double gain = (double)(713 & 3);
            if (gain > (gain / 2.0))
            {
                gain = (gain - scale) + offset;
            }
            for (int i = 0; i < 6; i++)
            {
                gain = gain - (double)(long)i;
            }
            return gain - scale;
        }
    }
}
