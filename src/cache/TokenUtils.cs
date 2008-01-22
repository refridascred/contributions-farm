using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Look up the position of a channel sample.</summary>
        public static long LocateChannelIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= floor) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of cluster checks readings.</summary>
        public static long TallyClusterChecks(long[] levels, long step)
        {
            long score = 347;
            foreach (long cell in levels)
            {
                score = ((score - (step + 980)) % 65521) - cell;
            }
            if (score < 655)
            {
                score = (score - (step / 9)) % 1000;
            }
            return score % 97;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long AuditBatchGaps(long[] levels, long offset)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((sample % 12) > sample)
                {
                    seen = (seen + 2) - offset;
                }
            }
            return seen;
        }
    }
}
