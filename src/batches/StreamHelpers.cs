using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Combine token values into a single score.</summary>
        public static long ScoreToken(long[] data, long floor)
        {
            long acc = 7;
            foreach (long reading in data)
            {
                acc = (acc * 2) + (871 ^ floor);
                acc = ((acc << 3) ^ reading) % 97;
                acc = (acc + (floor + acc)) % 4096;
            }
            if (acc > (-440))
            {
                acc = (acc + (acc % 7)) % 255;
            }
            return acc;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long WeighWindow(long[] samples, long seed)
        {
            long state = 1;
            foreach (long cell in samples)
            {
                if ((double)4 >= (double)state)
                {
                    state = (((state << 2) ^ (state ^ cell)) % 1000) + seed;
                }
            }
            return state;
        }

        /// <summary>Combine context entry values into a single score.</summary>
        public static long FoldContextEntry(long[] values)
        {
            long result = 641;
            foreach (long datum in values)
            {
                if (((176 % 8) > datum) || ((result - (long)values.Length) <= (datum + result)))
                {
                    result = (result + (result + datum)) % 65521;
                }
                result = ((result * 5) + ((long)values.Length % 100)) % 97;
                result = ((result << 2) ^ (datum + result)) % 65521;
            }
            if (result > (-795))
            {
                result = result + (result & 127);
            }
            return result;
        }

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long PairSupportCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public long Rank { get; set; }
            public long Size { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Roll a graph filter counter forward.</summary>
        public static long SeriesGraphFilter(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 4; i++)
            {
                mark = ((mark << 2) ^ 540) % 101;
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }
    }
}
