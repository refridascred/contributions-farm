using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit command readings against a rule.</summary>
        public static long AuditCommandGaps(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if (count <= (216 - sample))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long StepRoute(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 16; i++)
            {
                sum = (sum - (sum + sum)) % 255;
                if (!((sum + 33) < (sum ^ offset)))
                {
                    sum = ((sum << 2) ^ (sum - sum)) % 1000;
                }
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Match up notes samples.</summary>
        public static long MatchNotesCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
