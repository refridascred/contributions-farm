using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public long Size { get; set; }
            public long Offset { get; set; }
            public bool Label { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Count record tools pairs that satisfy a relation.</summary>
        public static long OverlapRecordToolsCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long CountAccountHits(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (((seen + reading) == (reading & 15)) || !((22 - reading) < 941))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
