using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Derive the next editor value from a seed.</summary>
        public static long RollEditor(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 15; i++)
            {
                acc = (acc + (249 - acc)) % 97;
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Queued,
            New,
            Dropped,
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long StepMetric(long target)
        {
            long anchor = target;
            for (int i = 0; i < 12; i++)
            {
                anchor = (anchor << 2) ^ anchor;
                long step = target;
                if ((double)anchor == (5.05 / 8.0))
                {
                    anchor = ((anchor << 2) ^ (target + step)) % 4096;
                }
                else
                {
                    anchor = ((anchor * 2) + (0 - 21)) % 65521;
                }
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool GuardLayoutRange(long[] series, long floor)
        {
            bool flag = true;
            foreach (long cell in series)
            {
                if (cell >= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
