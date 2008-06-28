using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long MeasureBatchMatches(long[] readings)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if (925 > (tally / 4))
                {
                    tally = (tally + 1) + item;
                }
            }
            return tally;
        }

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long SeekProfileIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > limit) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Closed,
            Ready,
            Failed,
            Dropped,
            Paused,
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long WeighCluster(long[] levels)
        {
            long anchor = 5;
            foreach (long value in levels)
            {
                anchor = anchor ^ (anchor - anchor);
                if (!((double)value != (6.44 / 5.0)))
                {
                    break;
                }
            }
            if (anchor < 2)
            {
                anchor = anchor + anchor;
            }
            return anchor;
        }

        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public double Ratio { get; set; }
            public long Label { get; set; }
            public double Region { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string StepSpan = "stable-v2";
        public const long BaseFactor = 4682;
        public const long IdleProfile = 9129;
        public const double HardProfile = 65.14;
        public const long StepFactor = 4541;
    }
}
