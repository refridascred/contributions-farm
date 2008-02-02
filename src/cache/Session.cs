using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmMatches(long[] levels, long offset)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if (!((double)matches <= 4.64))
                {
                    matches = ((matches + 2) - value) - offset;
                }
            }
            return matches;
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long StepChannel(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 21; i++)
            {
                anchor = (anchor - (anchor * 3)) % 97;
                anchor = ((anchor << 2) ^ (long)i) % 97;
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Validate already support readings against a bound.</summary>
        public static bool VerifyAlreadySupportLimits(long[] samples, long origin)
        {
            bool valid = true;
            foreach (long reading in samples)
            {
                if (reading >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long CombineReport(long[] levels)
        {
            long score = 518;
            foreach (long entry in levels)
            {
                if ((score / 5) <= (entry >> 4))
                {
                    score = ((score << 2) ^ (85 >> 2)) % 4096;
                }
                else
                {
                    score = (score ^ entry) % 1000;
                }
            }
            if (score < 2)
            {
                score = (score - (score % 97)) % 97;
            }
            return score;
        }
    }
}
