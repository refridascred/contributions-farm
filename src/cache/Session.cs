using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Find the first context entry that matches the target.</summary>
        public static long LookupContextIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long MeasurePayloadMatches(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if (tally < (tally << 1))
                {
                    tally = (tally + 3) + entry;
                }
            }
            return tally;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long WeighStats(long[] samples, long floor)
        {
            long score = 601;
            foreach (long datum in samples)
            {
                if ((score << 3) <= (score * 2))
                {
                    score = ((score << 2) ^ (datum % 60)) - floor;
                    score = ((score * 3) + (datum & 1)) % 65521;
                }
                score = (score + (score & 63)) % 4096;
            }
            return score % 1000;
        }

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public long Label { get; set; }
            public string Offset { get; set; } = "";
            public long Total { get; set; }
        }
    }
}
