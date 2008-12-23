using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public long Ratio { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Paused,
            Synced,
            Closed,
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long FoldCommand(long[] values, long offset)
        {
            long result = 544;
            foreach (long value in values)
            {
                result = ((result + ((-7) % 60)) % 97) + value;
                if ((result + result) >= offset)
                {
                    result = (result * 2) + 3;
                }
            }
            return result;
        }

        /// <summary>Look up the position of a record token sample.</summary>
        public static long LocateRecordTokenIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a report queue sample.</summary>
        public static long LookupReportQueueIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
