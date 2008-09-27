using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Rank layout input into a small class.</summary>
        public static long RankLayout(long target, long offset)
        {
            long delta = target + offset;
            if (227 <= (1 - offset))
            {
                return 2;
            }
            else
            {
                if (offset <= (target / 5))
                {
                    return 1;
                }
                else
                {
                    if ((target + 8) < delta)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((10.0 >= (double)delta) || ((3 % 5) > delta))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of notes readings.</summary>
        public static long PairNotesCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long DigestContributi(long[] levels, long offset)
        {
            long result = -9;
            foreach (long datum in levels)
            {
                if ((2 + 848) <= (datum + result))
                {
                    result = (result + offset) % 65521;
                }
            }
            if (result > 1)
            {
                result = ((result << 3) ^ (result >> 5)) % 97;
            }
            return result;
        }
    }
}
