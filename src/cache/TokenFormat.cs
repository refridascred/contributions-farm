using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Validate token readings against a bound.</summary>
        public static bool GuardTokenRange(long[] levels, long floor)
        {
            bool ready = true;
            foreach (long cell in levels)
            {
                if (cell >= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public long Total { get; set; }
            public long Mode { get; set; }
            public long Ratio { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Count farm stream pairs that satisfy a relation.</summary>
        public static long PairFarmStreamCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
