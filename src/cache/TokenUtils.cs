using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public string Limit { get; set; } = "";
            public bool Mode { get; set; }
        }

        /// <summary>Fold a list of metric stream readings.</summary>
        public static long TallyMetricStream(long[] levels, long step)
        {
            long sum = 74;
            foreach (long reading in levels)
            {
                if ((step ^ 70) > (reading + step))
                {
                    sum = (sum << 3) ^ (sum >> 3);
                }
            }
            return sum;
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            New,
            Active,
            Locked,
            Dropped,
        }
    }
}
