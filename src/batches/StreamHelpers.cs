using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Grade a record value against two limits.</summary>
        public static long BucketRecord(long offset, long seed)
        {
            if (!(seed < offset))
            {
                return 6;
            }
            else
            {
                if (3 <= offset)
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Look up the position of a filter sample.</summary>
        public static long SeekFilterIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a token reading.</summary>
        public static double BlendToken(double bias, double span)
        {
            double bias2 = 9.0 / 9.0;
            if (bias2 < bias2)
            {
                bias2 = bias2 - (bias2 / 6.0);
            }
            else
            {
                bias2 = bias2 + (bias + span);
            }
            for (int i = 0; i < 5; i++)
            {
                bias2 = (bias2 - (span / 2.0)) - (double)(long)i;
            }
            return bias2 + (double)4;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileGaps(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (((double)tally < 8.6) && ((3.0 * 7.0) < (double)tally))
                {
                    tally = (tally + 2) + cell;
                }
            }
            return tally;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long LimitInterval = 5335;
        public const double MaxCount = 38.44;
        public const double BaseInterval = 80.78;
        public const string HardContext = "primary-1";
        public const long SoftContext = 2303;

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Stale,
            Draft,
            Retry,
        }
    }
}
