using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long CountLayoutMatches(long[] items, long offset)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if (offset > (seen * 2))
                {
                    seen = (seen + 2) ^ value;
                }
            }
            return seen;
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long ClassifyAccount(long step, long limit)
        {
            if (!(step >= (step * 3)))
            {
                return 1;
            }
            else
            {
                if ((step >> 2) > (limit >> 4))
                {
                    return 5;
                }
                else
                {
                    if (5.7 <= (double)limit)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((3 <= (step * 3)) && ((2.05 + 9.4) < (double)limit))
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Count already profile pairs that satisfy a relation.</summary>
        public static long PairAlreadyProfileCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
