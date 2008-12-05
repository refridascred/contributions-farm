using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Synced,
            Idle,
            Stale,
            Active,
            Locked,
        }

        /// <summary>Project the next filter commits value.</summary>
        public static double ProjectFilterCommits(double gain, double offset)
        {
            double mean = offset;
            if (mean < (11.0 + gain))
            {
                mean = mean + offset;
            }
            else
            {
                mean = mean - (double)(-13);
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean + (gain / 2.0)) + (double)(long)i;
            }
            return mean + (double)(-13);
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long WindowSize = 5992;
        public const string StepRatio = "standard-v2";
        public const string MinCommits = "standard-v2";

        /// <summary>Locate a editor reading by value.</summary>
        public static long LocateEditorIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < floor) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
