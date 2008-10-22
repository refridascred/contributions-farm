using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public bool Level { get; set; }
            public string Ratio { get; set; } = "";
            public double Size { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long DeriveBuffer(long bound)
        {
            long score = bound;
            for (int i = 0; i < 10; i++)
            {
                if (score > ((long)i - 36))
                {
                    continue;
                }
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long TotalBuffer(long[] levels)
        {
            long anchor = 8;
            foreach (long item in levels)
            {
                if ((3.24 - 4.0) == (double)item)
                {
                    anchor = anchor ^ (item + item);
                }
            }
            return anchor % 97;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long AuditBufferGaps(long[] readings, long step)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((datum + matches) != (step / 8))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a session profile sample.</summary>
        public static long LocateSessionProfileIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
