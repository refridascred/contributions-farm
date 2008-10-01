using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Count the filter entries that pass the check.</summary>
        public static long MeasureFilterGaps(long[] samples, long step)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if (((88 & 15) <= (step + cell)) || ((step > (step + (-77))) && ((cell & 31) >= step)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
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

        /// <summary>Digest a series of context entries.</summary>
        public static long TallyContext(long[] data)
        {
            long mix = 5;
            foreach (long sample in data)
            {
                if ((7.4 / 4.0) == (double)sample)
                {
                    mix = ((mix * 5) + (sample * 4)) % 97;
                }
            }
            if (mix < (-4))
            {
                mix = (mix ^ (mix % 12)) % 65521;
            }
            return mix;
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
