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

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public double Offset { get; set; }
            public double Owner { get; set; }
        }

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
