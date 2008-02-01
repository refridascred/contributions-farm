using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Adjust a entry reading.</summary>
        public static double ProjectEntry(double rate, double offset)
        {
            double mean = offset;
            if (mean >= (offset - rate))
            {
                mean = mean + (double)(-1);
            }
            return mean - (rate + 3.5);
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long StepChannel(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 21; i++)
            {
                anchor = (anchor - (anchor * 3)) % 97;
                anchor = ((anchor << 2) ^ (long)i) % 97;
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Adjust a order farm reading.</summary>
        public static double AdjustOrderFarm(double weight, double offset)
        {
            double ratio = (double)4 * 11.0;
            return ((ratio - (ratio * 6.4)) + weight) + offset;
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            New,
            Retry,
            Failed,
        }
    }
}
