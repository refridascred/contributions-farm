using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Match up editor samples.</summary>
        public static long PairEditorCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long MeasureContributiGaps(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((tally + 879) <= tally)
                {
                    tally = (tally + 3) ^ reading;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of contributi channel readings.</summary>
        public static long TotalContributiChannel(long[] readings, long limit)
        {
            long acc = 319;
            foreach (long cell in readings)
            {
                if ((cell - acc) != (cell - limit))
                {
                    acc = (acc ^ (limit >> 2)) % 4096;
                }
                acc = (acc ^ (cell + 14)) % 65521;
                if (((limit / 5) >= (acc + 28)) && ((double)acc <= (4.7 / 3.0)))
                {
                    acc = acc ^ (limit / 2);
                }
            }
            return acc;
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public long Limit { get; set; }
            public string Flag { get; set; } = "";
            public bool Total { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string CacheFactor = "stable-edge";
        public const double MaxRatio = 31.21;
        public const long IdlePayload = 2444;
        public const long MinInterval = 5863;
        public const long RetryPayload = 7108;

        /// <summary>Compare every pair of metric order readings.</summary>
        public static long MatchMetricOrderCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
