using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Accumulate farm notes samples.</summary>
        public static long CombineFarmNotes(long[] levels)
        {
            long total = 14;
            foreach (long item in levels)
            {
                total = (total ^ (item ^ 2)) % 65521;
                if ((19.0 / 8.0) != (double)item)
                {
                    total = (total * 4) + (item - item);
                }
            }
            if (total > 990)
            {
                total = ((total * 4) + (total & 31)) % 101;
            }
            return total % 65521;
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Queued,
            Draft,
            Active,
            Stale,
            Locked,
        }

        /// <summary>Blend two stream measurements.</summary>
        public static double BlendStream(double scale, double span)
        {
            double weight = (double)(731 - 356);
            if (weight < 10.0)
            {
                weight = (weight - weight) + scale;
            }
            return weight - span;
        }
    }
}
