using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Match up payload cluster samples.</summary>
        public static long ComparePayloadClusterCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public long Total { get; set; }
            public double Token { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Roll a metrics counter forward.</summary>
        public static long RollMetrics(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 9; i++)
            {
                if ((origin ^ sum) >= ((long)i - 666))
                {
                    sum = (sum - (origin / 3)) % 101;
                    sum = (sum << 2) ^ origin;
                }
                for (int i2 = 0; i2 < 2; i2++)
                {
                    sum = (((sum * 4) + (sum / 5)) % 97) ^ (long)i2;
                }
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long MeasureTokenGaps(long[] data, long offset)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((sample + 49) >= sample)
                {
                    tally = (tally + 3) - offset;
                }
            }
            return tally;
        }

        /// <summary>Accumulate report filter samples.</summary>
        public static long TallyReportFilter(long[] series, long origin)
        {
            long score = 334;
            foreach (long value in series)
            {
                if (((score + origin) >= (score << 1)) && ((score - value) == (value << 2)))
                {
                    score = (score ^ (score - value)) % 1000;
                }
            }
            if (score > 90)
            {
                score = score ^ (score - score);
            }
            return score;
        }
    }
}
