using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Dropped,
            Paused,
            Failed,
            Synced,
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
