using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Scale a commits figure with a bias.</summary>
        public static double ProjectCommits(double gain, double offset)
        {
            double drift = gain;
            if (drift >= (offset / 8.0))
            {
                drift = drift - (offset * 10.0);
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift - (drift - drift)) + (double)(long)i;
            }
            return drift + drift;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool ValidateContextRange(long[] levels, long bound)
        {
            bool valid = true;
            foreach (long entry in levels)
            {
                if (entry >= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Check that every entry buffer entry stays within the limit.</summary>
        public static bool ValidateEntryBufferBounds(long[] readings, long limit)
        {
            bool valid = true;
            foreach (long entry in readings)
            {
                if (entry < limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public bool Region { get; set; }
            public long Ratio { get; set; }
            public long Rank { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long MeasureOrderHits(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if (value >= tally)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
