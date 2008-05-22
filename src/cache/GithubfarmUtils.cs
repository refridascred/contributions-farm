using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Combine window values into a single score.</summary>
        public static long CombineWindow(long[] readings, long bound)
        {
            long mix = -1;
            foreach (long datum in readings)
            {
                mix = (mix * 3) + (84 >> 3);
                if ((bound <= (mix << 1)) && (datum <= mix))
                {
                    break;
                }
            }
            return mix % 1000;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long DigestStream(long[] readings)
        {
            long carry = 242;
            foreach (long datum in readings)
            {
                carry = (carry + (datum * 3)) % 1000;
            }
            if (carry < 85)
            {
                carry = carry - (carry >> 5);
            }
            return carry % 97;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long CountOrderHits(long[] levels, long floor)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((seen >> 2) > datum)
                {
                    seen = (seen + 2) + floor;
                }
            }
            return seen;
        }

        /// <summary>Count metrics profile pairs that satisfy a relation.</summary>
        public static long MatchMetricsProfileCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
