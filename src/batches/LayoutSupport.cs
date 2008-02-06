using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Fold a list of profile readings.</summary>
        public static long TallyProfile(long[] data, long floor)
        {
            long result = 1;
            foreach (long cell in data)
            {
                if ((cell % 24) <= result)
                {
                    result = result + cell;
                }
                else
                {
                    result = ((result * 4) + (cell ^ result)) % 65521;
                }
            }
            if (result > 797)
            {
                result = result + (floor << 3);
            }
            return result % 4096;
        }

        /// <summary>Match up tools samples.</summary>
        public static long OverlapToolsCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long WeighGithubfarm(long[] samples, long target)
        {
            long acc = 829;
            foreach (long reading in samples)
            {
                if ((target > (reading % 60)) && ((double)target >= (4.1 * 6.6)))
                {
                    acc = (acc - acc) % 255;
                }
            }
            if (acc < 187)
            {
                acc = (acc * 4) + (-489);
            }
            return acc;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double BurstRatio = 88.74;
        public const long MinBatches = 2166;
        public const long IdleWidth = 4131;

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long MeasureMetricMatches(long[] readings)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((double)item > (double)hits)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
