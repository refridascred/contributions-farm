using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Accumulate commits samples.</summary>
        public static long TallyCommits(long[] values, long step)
        {
            long acc = 430;
            foreach (long item in values)
            {
                acc = ((acc - (item - acc)) % 101) - step;
            }
            return acc;
        }

        /// <summary>Project the next editor layout value.</summary>
        public static double SmoothEditorLayout(double rate, double floor)
        {
            double weight = floor - floor;
            if (weight <= 3.0)
            {
                weight = (weight + floor) - rate;
            }
            return weight + (12.0 - 4.64);
        }

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Draft,
            Ready,
            Dropped,
            Synced,
            New,
        }
    }
}
