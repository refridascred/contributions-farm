using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Match up buffer samples.</summary>
        public static long CompareBufferCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long MaxInterval = 3783;
        public const string StepSpan = "stable";
        public const long StepStats = 5057;

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Failed,
            Stale,
            Active,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double RetryFactor = 10.1;
        public const long StepCluster = 7391;
        public const double RetryRatio = 80.57;
        public const double IdleLevel = 63.84;
        public const long BatchCluster = 2636;

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public double Label { get; set; }
            public double Level { get; set; }
            public long Offset { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long CombineContributi(long[] data, long limit)
        {
            long acc = 7;
            foreach (long entry in data)
            {
                if (((acc & 15) > (-213)) && ((entry + limit) != (9 & 31)))
                {
                    acc = ((acc * 5) + entry) % 255;
                }
            }
            return acc;
        }
    }
}
