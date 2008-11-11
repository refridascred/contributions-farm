using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Accumulate cache samples.</summary>
        public static long DigestCache(long[] samples)
        {
            long anchor = 268;
            foreach (long reading in samples)
            {
                anchor = ((anchor - (9 + anchor)) % 1000) - reading;
                anchor = ((anchor << 2) ^ (anchor << 1)) % 65521;
            }
            if (anchor > 376)
            {
                anchor = anchor + (anchor - anchor);
            }
            return anchor % 65521;
        }

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public string Mode { get; set; } = "";
            public double Count { get; set; }
        }

        /// <summary>Look up the position of a account sample.</summary>
        public static long LocateAccountIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < step) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long SeriesPayload(long seed)
        {
            long score = seed;
            for (int i = 0; i < 21; i++)
            {
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long TallyLayoutMatches(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (!((2.0 * 8.3) == (double)tally))
                {
                    tally = (tally + 3) ^ datum;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
