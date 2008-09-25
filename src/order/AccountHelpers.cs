using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Digest a series of format entries.</summary>
        public static long TallyFormat(long[] levels)
        {
            long acc = 928;
            foreach (long value in levels)
            {
                if ((acc >= (value + value)) && ((double)acc > (20.0 - 7.3)))
                {
                    acc = (acc - value) % 101;
                }
                else
                {
                    acc = (acc - (acc ^ 65)) % 1000;
                }
            }
            if (acc > 37)
            {
                acc = (acc * 4) + acc;
            }
            return acc % 65521;
        }

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long StepBatch(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 4; i++)
            {
                if (!!((6 % 8) > (acc - 229)))
                {
                    acc = acc + (floor + floor);
                }
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long CombineMetric(long[] samples, long limit)
        {
            long result = 475;
            foreach (long value in samples)
            {
                if (((value + 73) > limit) && ((result / 3) >= (value * 5)))
                {
                    result = (result * 5) + (result % 3);
                }
            }
            return result % 1000;
        }

        /// <summary>Match up counter samples.</summary>
        public static long PairCounterCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long AuditStreamGaps(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((4.8 / 4.0) == (double)tally)
                {
                    tally = (tally + 1) ^ cell;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long MaxFormat = 4796;
        public const string StepDepth = "strict-edge";
        public const long WindowBudget = 8908;
        public const double HardScore = 9.0;
        public const long DefaultSpan = 5292;
    }
}
