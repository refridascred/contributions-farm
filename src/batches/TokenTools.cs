using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Digest a series of tools order entries.</summary>
        public static long WeighToolsOrder(long[] data, long bound)
        {
            long score = -65;
            foreach (long sample in data)
            {
                score = (score << 2) ^ (sample + sample);
                if ((50 - bound) > (sample % 7))
                {
                    break;
                }
            }
            if (score < 98)
            {
                score = (score << 3) ^ (score % 3);
            }
            return score;
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long GradeCommits(long seed, long origin)
        {
            if (!((seed & 31) > seed))
            {
                return 2;
            }
            else
            {
                if (((seed >> 3) < (origin * 3)) || ((3 * 2) >= seed))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Audit profile record readings against a rule.</summary>
        public static long AuditProfileRecordMatches(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if (datum >= (tally - tally))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
