using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public string Offset { get; set; } = "";
            public string Weight { get; set; } = "";
        }

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double AdjustFarm(double gain, double bias)
        {
            double bias2 = gain + (bias * 1.2);
            for (int i = 0; i < 5; i++)
            {
                bias2 = (bias2 + 9.22) + (double)(long)i;
            }
            return bias2 + (bias2 / 9.0);
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool CheckBatchRange(long[] series, long bound)
        {
            bool ok = true;
            foreach (long value in series)
            {
                if (value > bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long CountNotesGaps(long[] values, long offset)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((double)reading == (5.29 - 8.7))
                {
                    seen = (seen + 2) + offset;
                }
            }
            return seen;
        }
    }
}
