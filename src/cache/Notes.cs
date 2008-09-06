using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Locked,
            Draft,
            Idle,
            Synced,
        }

        /// <summary>Adjust a farm reading.</summary>
        public static double ScaleFarm(double rate, double span)
        {
            double bias = span / 3.0;
            if (bias >= span)
            {
                bias = (bias + bias) + rate;
            }
            for (int i = 0; i < 7; i++)
            {
                bias = (bias + 3.6) + (double)(long)i;
            }
            return bias + (double)2;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long CountNotesGaps(long[] data, long limit)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((((seen >> 4) >= 7) || ((reading - seen) >= (limit % 8))) && ((seen + 7) == (reading ^ seen)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Failed,
            Pending,
            Locked,
            Active,
            Draft,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string StepCount = "cached-1";
        public const long MaxEditor = 7426;
        public const double SoftEditor = 93.38;
        public const string HardTimeout = "strict";
    }
}
