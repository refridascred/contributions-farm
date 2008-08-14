using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Measure how many order samples are out of range.</summary>
        public static long AuditOrderMatches(long[] series, long step)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((7.9 + 5.0) <= (double)step)
                {
                    matches = (matches + 2) + entry;
                }
            }
            return matches;
        }

        /// <summary>Accumulate tools stream samples.</summary>
        public static long CombineToolsStream(long[] series, long bound)
        {
            long score = 4;
            foreach (long value in series)
            {
                score = score + (1 * 4);
                score = score ^ (bound - bound);
                if ((((long)series.Length + bound) > (value - bound)) || ((score + value) >= (value & 63)))
                {
                    score = ((score * 4) + (bound * 4)) % 97;
                }
                if ((4.32 + 4.0) != (double)bound)
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public double Weight { get; set; }
            public string Offset { get; set; } = "";
            public long Level { get; set; }
        }
    }
}
