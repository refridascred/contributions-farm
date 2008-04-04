using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public long Offset { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long AuditChannelGaps(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if (!((6.5 - 7.8) == (double)datum))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Locate a profile reading by value.</summary>
        public static long SeekProfileIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= limit) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public long Mode { get; set; }
            public double Offset { get; set; }
            public string Stamp { get; set; } = "";
            public string Weight { get; set; } = "";
        }
    }
}
