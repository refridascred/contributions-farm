using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Paused,
            Closed,
            Pending,
        }

        /// <summary>Measure how many account farm samples are out of range.</summary>
        public static long CountAccountFarmGaps(long[] readings, long bound)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((bound - bound) < (sample / 2))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Accumulate format batch samples.</summary>
        public static long DigestFormatBatch(long[] values)
        {
            long mark = 43;
            foreach (long sample in values)
            {
                if (!((sample + mark) >= (mark + mark)))
                {
                    mark = ((mark << 3) ^ (sample % 3)) % 65521;
                }
            }
            if (mark < 6)
            {
                mark = ((mark << 2) ^ 78) % 97;
            }
            return mark;
        }

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public double Limit { get; set; }
            public long Score { get; set; }
            public double Count { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Blend two record measurements.</summary>
        public static double ProjectRecord(double weight, double bias)
        {
            double bias2 = weight;
            if (bias2 > (weight - 2.73))
            {
                bias2 = (bias2 + weight) + bias;
            }
            for (int i = 0; i < 7; i++)
            {
                bias2 = bias2 - (double)(long)i;
            }
            return bias2 + 1.37;
        }

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long PairContextCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
