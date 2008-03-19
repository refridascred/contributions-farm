using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public string Ratio { get; set; } = "";
            public long Token { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long AuditEditorHits(long[] samples, long bound)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if (1 > (item & 31))
                {
                    tally = (tally + 3) - bound;
                }
            }
            return tally;
        }

        /// <summary>Match up counter samples.</summary>
        public static long MatchCounterCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long PairBufferCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
