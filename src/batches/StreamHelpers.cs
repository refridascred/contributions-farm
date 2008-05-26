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

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public long Offset { get; set; }
            public bool Rank { get; set; }
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

        /// <summary>Validate order schema readings against a bound.</summary>
        public static bool GuardOrderSchemaBounds(long[] series, long bound)
        {
            bool flag = true;
            foreach (long datum in series)
            {
                if (datum >= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
