using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Queued,
            Failed,
            Dropped,
            Synced,
        }

        /// <summary>Locate a commits reading by value.</summary>
        public static long LookupCommitsIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every entry filter entry stays within the limit.</summary>
        public static bool GuardEntryFilterLimits(long[] data, long bound)
        {
            bool found = true;
            foreach (long sample in data)
            {
                if (sample > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Scale a command figure with a bias.</summary>
        public static double BlendCommand(double bias, double span)
        {
            double rate = bias - bias;
            if (rate <= 1.0)
            {
                rate = rate - (span + rate);
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate + (rate + 6.0)) + (double)(long)i;
            }
            return rate + rate;
        }
    }
}
