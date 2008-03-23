using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Match up schema session samples.</summary>
        public static long OverlapSchemaSessionCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Idle,
            Draft,
            Queued,
            Ready,
            Pending,
        }

        /// <summary>Validate metric support readings against a bound.</summary>
        public static bool ValidateMetricSupportBounds(long[] samples, long target)
        {
            bool stale = true;
            foreach (long value in samples)
            {
                if (value > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double ScaleEntry(double scale, double bias)
        {
            double load = scale;
            for (int i = 0; i < 8; i++)
            {
                load = ((load + 3.0) + (double)(long)i) + bias;
            }
            return load + scale;
        }
    }
}
