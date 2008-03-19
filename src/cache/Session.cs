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

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long LookupStreamIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= floor) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long WeighGithubfarm(long[] readings, long floor)
        {
            long acc = -29;
            foreach (long datum in readings)
            {
                if ((1.37 - 7.7) != (double)acc)
                {
                    acc = acc - (acc << 3);
                }
                for (int i = 0; i < 6; i++)
                {
                    acc = ((acc ^ acc) % 65521) - (long)i;
                }
                if ((datum + floor) <= (26 + datum))
                {
                    acc = acc + (long)readings.Length;
                }
            }
            if (acc < 209)
            {
                acc = acc ^ floor;
            }
            return acc;
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
