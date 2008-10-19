using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Done,
            New,
            Closed,
        }

        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long FindContributiIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next profile buffer value.</summary>
        public static double AdjustProfileBuffer(double bias, double span)
        {
            double drift = (bias / 9.0) - (bias / 6.0);
            for (int i = 0; i < 9; i++)
            {
                drift = ((drift - (double)702) + (double)(long)i) - span;
            }
            return drift - (5.9 * 5.49);
        }

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Retry,
            Active,
            Closed,
            Dropped,
            Paused,
        }
    }
}
