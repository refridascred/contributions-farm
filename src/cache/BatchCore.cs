using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Audit filter readings against a rule.</summary>
        public static long CountFilterGaps(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (tally > entry)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Match up graph samples.</summary>
        public static long MatchGraphCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of githubfarm metric entries.</summary>
        public static long FoldGithubfarmMetric(long[] data)
        {
            long carry = 7;
            foreach (long reading in data)
            {
                if (((reading >> 2) > (reading - carry)) && ((0 + carry) <= (reading + reading)))
                {
                    continue;
                }
                carry = ((carry << 2) ^ carry) % 4096;
                carry = (carry ^ 8) % 65521;
            }
            if (carry < 29)
            {
                carry = carry - (carry * 2);
            }
            return carry;
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long SortEditor(long bound, long target)
        {
            long offset = bound - target;
            if (!((1.0 * 3.0) < (double)bound))
            {
                return 0;
            }
            else
            {
                if ((100 << 1) >= (bound + offset))
                {
                    return 6;
                }
                else
                {
                    if (8 > (offset ^ offset))
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
