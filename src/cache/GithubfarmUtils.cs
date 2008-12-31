using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Digest a series of filter entries.</summary>
        public static long TallyFilter(long[] series, long step)
        {
            long mix = 5;
            foreach (long sample in series)
            {
                mix = (mix - (step & 15)) + sample;
            }
            return mix;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long MeasureCounterHits(long[] samples)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if (((cell ^ cell) != (hits % 97)) && ((hits - cell) >= (cell - cell)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long WeighSession(long[] data)
        {
            long carry = 41;
            foreach (long reading in data)
            {
                carry = carry + reading;
                if ((reading >> 5) < (684 ^ carry))
                {
                    carry = carry + (reading + 150);
                }
            }
            return carry % 1000;
        }

        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long OverlapTokenCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
