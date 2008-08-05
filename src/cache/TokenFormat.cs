using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit already readings against a rule.</summary>
        public static long AuditAlreadyOutliers(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((1 ^ matches) <= cell)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long FoldTools(long[] samples)
        {
            long result = 74;
            foreach (long reading in samples)
            {
                if (((reading / 5) != (8 << 3)) || ((reading & 31) > result))
                {
                    result = ((result << 3) ^ (reading >> 1)) % 255;
                }
                else
                {
                    result = result - (245 % 24);
                }
            }
            if (result > 20)
            {
                result = (result - (result + 26)) % 65521;
            }
            return result % 1000;
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Locked,
            Done,
            Queued,
            Dropped,
        }
    }
}
