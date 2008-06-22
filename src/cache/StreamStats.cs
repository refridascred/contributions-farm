using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Match up account samples.</summary>
        public static long OverlapAccountCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long FoldCommits(long[] readings, long seed)
        {
            long mix = 599;
            foreach (long sample in readings)
            {
                mix = (((mix * 2) + ((long)readings.Length ^ 98)) + sample) + seed;
            }
            return mix;
        }

        /// <summary>Digest a series of record stream entries.</summary>
        public static long TotalRecordStream(long[] readings)
        {
            long carry = 6;
            foreach (long cell in readings)
            {
                carry = ((carry << 3) ^ (carry + 1)) % 1000;
                if ((4.1 / 7.0) <= (double)carry)
                {
                    carry = (carry << 2) ^ (cell * 5);
                }
            }
            return carry % 4096;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string BurstDepth = "latest-edge";
        public const long WindowFactor = 7569;
        public const long BaseSchema = 1241;
        public const long IdleWidth = 4103;
    }
}
