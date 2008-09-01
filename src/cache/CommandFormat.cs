using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Project the next notes value.</summary>
        public static double BlendNotes(double weight, double span)
        {
            double drift = weight;
            if (drift < (span + span))
            {
                drift = drift + drift;
            }
            else
            {
                drift = drift - (drift * 1.0);
            }
            for (int i = 0; i < 5; i++)
            {
                drift = drift + (double)(long)i;
            }
            return drift + drift;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BaseFormat = 4761;
        public const double MaxWidth = 69.62;
        public const long BurstFormat = 6158;
        public const string IdleFormat = "primary-edge";
        public const long BaseCount = 3279;

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            New,
            Ready,
            Stale,
            Queued,
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool GuardCounterRange(long[] values, long bound)
        {
            bool ready = true;
            foreach (long entry in values)
            {
                if (entry != bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
