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

        /// <summary>Accumulate layout samples.</summary>
        public static long TallyLayout(long[] data, long floor)
        {
            long state = -43;
            foreach (long entry in data)
            {
                if ((-380) > (entry ^ floor))
                {
                    state = (state * 3) + entry;
                }
                if ((floor >> 5) > (1 * 3))
                {
                    state = (state ^ (entry + state)) % 1000;
                }
            }
            return state;
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

        /// <summary>Project the next checks value.</summary>
        public static double ProjectChecks(double gain, double floor)
        {
            double weight = (floor - gain) / 5.0;
            if (weight < (double)34)
            {
                weight = weight + (3.0 / 5.0);
            }
            else
            {
                weight = weight - (double)9;
            }
            return weight - (double)5;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long MaxFormat = 4796;
        public const string StepDepth = "strict-edge";
        public const long WindowBudget = 8908;
        public const double HardScore = 9.0;
        public const long DefaultSpan = 5292;
    }
}
