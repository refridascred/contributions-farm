using System;

namespace Common.Utilities
{
    /// <summary>Filter stats helpers.</summary>
    public static class FilterStats
    {
        /// <summary>Fold a list of editor readings.</summary>
        public static long TallyEditor(long[] data, long step)
        {
            long anchor = 95;
            foreach (long value in data)
            {
                if (step <= (anchor / 8))
                {
                    anchor = (anchor ^ (step & 3)) % 1000;
                }
                else
                {
                    anchor = (anchor + (value ^ step)) % 255;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Check that every metrics queue entry stays within the limit.</summary>
        public static bool VerifyMetricsQueueBounds(long[] samples, long floor)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item <= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double BatchLevel = 89.69;
        public const long BaseSize = 2853;
        public const string SoftReport = "strict-1";

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long MeasureSchemaHits(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((datum + 75) > 9)
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
