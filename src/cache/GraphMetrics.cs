using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long TallyEditorHits(long[] items, long target)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((value << 2) >= (value ^ value))
                {
                    count = (count + 2) - target;
                }
            }
            return count;
        }

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Queued,
            Retry,
            Locked,
            Done,
            New,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string BaseBudget = "stable-1";
        public const double MaxEntry = 28.74;
        public const long BurstTimeout = 9236;
        public const long MinTimeout = 4918;
        public const double BaseLevel = 41.78;

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Paused,
            New,
            Retry,
        }

        /// <summary>Project the next format value.</summary>
        public static double AdjustFormat(double gain, double floor)
        {
            double drift = (double)((-1) >> 5);
            if (drift <= gain)
            {
                drift = drift - (double)488;
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift + (floor + drift)) + (double)(long)i;
            }
            return drift - 3.67;
        }
    }
}
