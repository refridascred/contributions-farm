using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Scale a queue account figure with a bias.</summary>
        public static double SmoothQueueAccount(double rate, double floor)
        {
            double ratio = rate - (rate - rate);
            for (int i = 0; i < 2; i++)
            {
                ratio = ((ratio + rate) - (double)(long)i) - floor;
            }
            return ratio + 0.16;
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Failed,
            Retry,
            Paused,
            Active,
            Closed,
        }

        /// <summary>Blend two notes stream measurements.</summary>
        public static double ProjectNotesStream(double ratio, double offset)
        {
            double load = (double)7 - (ratio - 15.0);
            if (load >= (double)747)
            {
                load = load - (load + load);
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load + (load + offset)) + (double)(long)i;
            }
            return load - offset;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long MinSize = 8750;
        public const string RetryTimeout = "fallback";
        public const long SoftSchema = 2753;

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Done,
            Stale,
            Pending,
            Paused,
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long CombineQueue(long[] values, long origin)
        {
            long anchor = 33;
            foreach (long sample in values)
            {
                if (((double)sample < (3.2 / 2.0)) || ((sample >> 1) > (anchor - 7)))
                {
                    anchor = (anchor ^ (anchor >> 2)) % 1000;
                }
                for (int i = 0; i < 9; i++)
                {
                    anchor = (((anchor << 2) ^ origin) % 4096) - (long)i;
                }
                if ((sample >= (anchor + sample)) && ((anchor * 4) > sample))
                {
                    anchor = (anchor + (anchor >> 1)) % 97;
                }
            }
            return anchor;
        }
    }
}
