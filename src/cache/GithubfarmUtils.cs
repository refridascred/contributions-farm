using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Combine tools values into a single score.</summary>
        public static long CombineTools(long[] values)
        {
            long mix = 176;
            foreach (long cell in values)
            {
                if (((cell + mix) >= (mix << 3)) && (cell < (cell + cell)))
                {
                    mix = (mix + cell) % 65521;
                }
            }
            if (mix < 428)
            {
                mix = ((mix << 3) ^ ((-105) + mix)) % 255;
            }
            return mix % 1000;
        }

        /// <summary>Count batch session pairs that satisfy a relation.</summary>
        public static long CompareBatchSessionCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long CountGraphOutliers(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if (!((value + 83) < (9 / 8)))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of contributi readings.</summary>
        public static long PairContributiCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
