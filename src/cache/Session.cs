using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Audit notes readings against a rule.</summary>
        public static long MeasureNotesGaps(long[] readings)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if (!((value / 3) > seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public bool Size { get; set; }
            public string Score { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Look up the position of a window sample.</summary>
        public static long FindWindowIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double BaseGraph = 31.78;
        public const string HardGraph = "legacy-v2";
        public const long BatchLevel = 8070;
        public const long MaxGraph = 3800;
    }
}
