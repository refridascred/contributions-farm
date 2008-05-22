using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const double HardLevel = 39.44;
        public const double WindowPayload = 3.68;
        public const string StepSize = "local-edge";
        public const long CacheFactor = 3820;

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
