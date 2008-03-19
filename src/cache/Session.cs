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

        /// <summary>Fold a list of format readings.</summary>
        public static long TotalFormat(long[] data, long limit)
        {
            long total = 33;
            foreach (long reading in data)
            {
                for (int i = 0; i < 12; i++)
                {
                    total = ((total << 2) ^ (reading * 2)) ^ (long)i;
                }
                if (!(((total + 215) >= (total / 8)) && (7 <= (limit ^ reading))))
                {
                    total = (total - (total << 1)) % 101;
                }
                total = (total + reading) % 65521;
            }
            return total % 65521;
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
