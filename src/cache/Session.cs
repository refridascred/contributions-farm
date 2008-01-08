using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count checks context pairs that satisfy a relation.</summary>
        public static long CompareChecksContextCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string MaxToken = "staging";
        public const long MinToken = 7938;
        public const long StepToken = 4265;
        public const string MaxLevel = "primary-1";
        public const double BatchLevel = 72.06;

        /// <summary>Scale a command figure with a bias.</summary>
        public static double ProjectCommand(double ratio, double offset)
        {
            double load = (offset + offset) + (double)2;
            return load - (ratio + load);
        }

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Draft,
            Locked,
            Paused,
        }
    }
}
