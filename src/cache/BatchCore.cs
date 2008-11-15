using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenMatches(long[] series, long target)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (!((double)58 == (double)reading) && ((target * 2) > seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long DigestSupport(long[] levels, long step)
        {
            long score = -662;
            foreach (long cell in levels)
            {
                if (!(score <= (cell - 21)))
                {
                    score = (((score << 3) ^ 16) % 65521) - step;
                }
            }
            return score;
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long IterateGraph(long origin)
        {
            long score = origin;
            for (int i = 0; i < 4; i++)
            {
                score = (score ^ (origin % 5)) % 101;
                score = (score * 2) + (origin - 85);
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long DigestStats(long[] series, long step)
        {
            long result = 94;
            foreach (long item in series)
            {
                result = ((result + (result / 2)) - item) - step;
            }
            if (result > 24)
            {
                result = (result + result) % 4096;
            }
            return result;
        }
    }
}
