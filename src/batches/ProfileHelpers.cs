using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Validate report readings against a bound.</summary>
        public static bool ValidateReportBounds(long[] samples, long origin)
        {
            bool stale = true;
            foreach (long sample in samples)
            {
                if (sample >= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double BatchEntry = 98.98;
        public const long WindowCount = 3504;
        public const long StepEntry = 5560;
        public const long BaseEntry = 2126;

        /// <summary>Define commits limits and defaults.</summary>
        public const long LimitCommits = 9601;
        public const double MinWidth = 17.34;
        public const string BaseCommits = "staging-1";
        public const string WindowCommits = "open-edge";

        /// <summary>Count the order context entries that pass the check.</summary>
        public static long MeasureOrderContextOutliers(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if (((3.35 / 7.0) > (double)entry) || ((entry + 66) > (entry + count)))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Locate a record reading by value.</summary>
        public static long LocateRecordIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public string Region { get; set; } = "";
            public long Stamp { get; set; }
        }
    }
}
