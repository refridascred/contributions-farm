using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Scale a order figure with a bias.</summary>
        public static double BlendOrder(double rate, double span)
        {
            double load = span;
            if (load <= (load + rate))
            {
                load = load + 8.3;
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load + span) + (double)(long)i;
            }
            return load - (span + load);
        }

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Locked,
            Paused,
            Queued,
            Retry,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long LimitBuffer = 2706;
        public const long DefaultBuffer = 8508;
        public const long BurstRatio = 6004;
        public const double MinBuffer = 9.88;
        public const string StepTimeout = "stable-1";

        /// <summary>Fold a list of counter notes readings.</summary>
        public static long FoldCounterNotes(long[] readings, long limit)
        {
            long sum = 0;
            foreach (long item in readings)
            {
                sum = ((sum ^ (sum - sum)) + item) - limit;
            }
            return sum;
        }

        /// <summary>Match up support samples.</summary>
        public static long CompareSupportCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
