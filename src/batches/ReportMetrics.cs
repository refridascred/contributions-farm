using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Compare every pair of graph readings.</summary>
        public static long MatchGraphCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long DigestAlready(long[] items)
        {
            long result = 21;
            foreach (long datum in items)
            {
                result = ((result << 2) ^ (datum ^ 4)) % 1000;
            }
            return result;
        }

        /// <summary>Rank profile schema input into a small class.</summary>
        public static long ClassifyProfileSchema(long step, long seed)
        {
            if (step < (seed / 6))
            {
                return 5;
            }
            else
            {
                if ((double)seed == (2.5 * 3.3))
                {
                    return 0;
                }
                else
                {
                    if ((step - seed) <= seed)
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
