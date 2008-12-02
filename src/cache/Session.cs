using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public long Total { get; set; }
            public bool Count { get; set; }
            public string Offset { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long CompareNotesCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Idle,
            Paused,
            Active,
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long TotalSchema(long[] readings, long bound)
        {
            long mark = 29;
            foreach (long cell in readings)
            {
                mark = (mark << 3) ^ (cell % 60);
                mark = ((mark << 2) ^ (bound << 1)) % 4096;
                if (8 <= (bound * 2))
                {
                    break;
                }
            }
            return mark;
        }
    }
}
