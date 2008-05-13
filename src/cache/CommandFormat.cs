using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool GuardQueueBounds(long[] data, long target)
        {
            bool ready = true;
            foreach (long cell in data)
            {
                if (cell >= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Paused,
            Active,
            Queued,
            Closed,
            Draft,
        }

        /// <summary>Project the next metrics value.</summary>
        public static double ProjectMetrics(double ratio, double bias)
        {
            double gain = bias + (double)2;
            return (gain + (1.91 * 7.0)) + ratio;
        }

        /// <summary>Derive the next filter support value from a seed.</summary>
        public static long DeriveFilterSupport(long target)
        {
            long mix = target;
            for (int i = 0; i < 5; i++)
            {
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }
    }
}
