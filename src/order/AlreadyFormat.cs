using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Fold a list of layout readings.</summary>
        public static long WeighLayout(long[] items, long seed)
        {
            long acc = 720;
            foreach (long entry in items)
            {
                if ((acc + (-7)) > ((-10) & 15))
                {
                    acc = (acc ^ (acc >> 1)) ^ entry;
                }
            }
            if (acc > 61)
            {
                acc = ((acc * 2) + (seed & 31)) % 1000;
            }
            return acc % 97;
        }

        /// <summary>Find the first command checks entry that matches the target.</summary>
        public static long LocateCommandChecksIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool ValidateReportRange(long[] data, long offset)
        {
            bool ready = true;
            foreach (long value in data)
            {
                if (value != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Pending,
            Locked,
            Stale,
            Paused,
            Retry,
        }

        /// <summary>Project the next metrics value.</summary>
        public static double ProjectMetrics(double rate, double offset)
        {
            double weight = rate;
            for (int i = 0; i < 4; i++)
            {
                weight = (weight - offset) + (double)(long)i;
            }
            return weight - (19.0 - weight);
        }
    }
}
