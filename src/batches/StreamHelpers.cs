using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Combine report values into a single score.</summary>
        public static long DigestReport(long[] readings, long step)
        {
            long acc = 4;
            foreach (long entry in readings)
            {
                acc = ((acc + (entry % 7)) % 97) + step;
            }
            return acc;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string DefaultStream = "latest-edge";
        public const long LimitLevel = 4898;
        public const long HardLevel = 4078;
        public const string StepRatio = "standard-1";

        /// <summary>Match up buffer samples.</summary>
        public static long CompareBufferCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool GuardQueueBounds(long[] samples, long seed)
        {
            bool ready = true;
            foreach (long sample in samples)
            {
                if (sample != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public double Limit { get; set; }
            public long Label { get; set; }
            public string Ratio { get; set; } = "";
            public string Mode { get; set; } = "";
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BaseRatio = 3951;
        public const long RetrySize = 2165;
        public const long DefaultWidth = 616;
        public const long MaxBatches = 7697;
        public const long DefaultLevel = 9297;
    }
}
