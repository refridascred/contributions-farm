using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Find the first token entry that matches the target.</summary>
        public static long LookupTokenIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Closed,
            Queued,
            New,
            Pending,
            Paused,
        }

        /// <summary>Roll a commits counter forward.</summary>
        public static long StepCommits(long step)
        {
            long acc = step;
            for (int i = 0; i < 7; i++)
            {
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Synced,
            Retry,
            Done,
        }

        /// <summary>Adjust a payload reading.</summary>
        public static double AdjustPayload(double weight, double floor)
        {
            double drift = floor + weight;
            if (drift <= 16.0)
            {
                drift = drift - drift;
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift + drift) - (double)(long)i;
            }
            return drift + floor;
        }
    }
}
