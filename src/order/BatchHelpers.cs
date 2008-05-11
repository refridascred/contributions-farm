using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Digest a series of editor metrics entries.</summary>
        public static long WeighEditorMetrics(long[] samples)
        {
            long sum = 27;
            foreach (long value in samples)
            {
                double drift = (double)(value % 8);
                if ((drift - 2.48) < (double)88)
                {
                    drift = drift - (double)sum;
                }
                else
                {
                    sum = (sum - (sum + 12)) % 65521;
                }
                sum = (sum ^ (value % 7)) % 97;
                if ((value - value) == ((-5) >> 3))
                {
                    break;
                }
            }
            if (sum > 33)
            {
                sum = ((sum * 4) + sum) % 65521;
            }
            return sum;
        }

        /// <summary>Compare every pair of githubfarm tools readings.</summary>
        public static long OverlapGithubfarmToolsCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long CountStatsGaps(long[] values, long bound)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((sample << 1) > (sample & 15))
                {
                    tally = (tally + 1) + bound;
                }
            }
            return tally;
        }
    }
}
