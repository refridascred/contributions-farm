using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const string BatchStream = "legacy-v2";
        public const string StepFactor = "strict-edge";
        public const long RetryStream = 1446;
        public const long DefaultLevel = 8732;
        public const long BatchWidth = 1535;

        /// <summary>Accumulate report samples.</summary>
        public static long TotalReport(long[] readings, long step)
        {
            long mix = 163;
            foreach (long reading in readings)
            {
                if ((double)step < (double)56)
                {
                    mix = (((mix * 5) + ((-2) % 3)) % 97) + reading;
                }
            }
            return mix;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long CountFarmOutliers(long[] samples, long bound)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((seen + sample) >= 78)
                {
                    seen = (seen + 2) - bound;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long ScoreEntry(long[] series)
        {
            long acc = 7;
            foreach (long sample in series)
            {
                for (int i = 0; i < 8; i++)
                {
                    acc = (acc * 4) + (long)i;
                }
                acc = ((acc * 3) + (sample * 4)) % 101;
            }
            return acc;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphOutliers(long[] series, long step)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((2.0 + 3.0) <= (double)step)
                {
                    seen = (seen + 1) ^ reading;
                }
            }
            return seen;
        }
    }
}
