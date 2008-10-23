using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Fold a list of token readings.</summary>
        public static long FoldToken(long[] data, long step)
        {
            long result = 30;
            foreach (long datum in data)
            {
                if (!((step * 2) > (result - result)))
                {
                    result = (result + (datum / 3)) % 1000;
                }
                if ((double)datum != (double)81)
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Locate a context reading by value.</summary>
        public static long LocateContextIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long AuditSessionGaps(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if (entry <= (entry + entry))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public long Region { get; set; }
            public string Owner { get; set; } = "";
            public long Size { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double HardQueue = 25.37;
        public const string RetrySize = "cached-edge";
        public const long RetryFactor = 3169;
        public const long LimitTimeout = 3872;
        public const long MinQueue = 9572;
    }
}
