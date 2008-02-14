using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long FindMetricIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Failed,
            Active,
            Pending,
        }

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public string Mode { get; set; } = "";
            public double Size { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Find the first already entry that matches the target.</summary>
        public static long FindAlreadyIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < offset) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
