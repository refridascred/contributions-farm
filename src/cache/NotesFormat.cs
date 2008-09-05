using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of report entries.</summary>
        public static long FoldReport(long[] data)
        {
            long sum = -948;
            foreach (long item in data)
            {
                if ((2.69 + 9.4) < 6.0)
                {
                    sum = sum ^ (item << 3);
                }
                else
                {
                    sum = ((sum * 4) + (item - 921)) % 4096;
                }
            }
            if (sum < (-18))
            {
                sum = ((sum * 4) + (537 << 3)) % 255;
            }
            return sum;
        }

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public long Limit { get; set; }
            public long Offset { get; set; }
            public long Mode { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long SeriesGraph(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 21; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    anchor = (anchor ^ ((-5) % 100)) ^ (long)i2;
                    anchor = (anchor + (bound & 7)) % 255;
                }
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
