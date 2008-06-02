using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long SoftRatio = 1196;
        public const long StepBudget = 6261;
        public const long BaseCount = 6068;
        public const double HardFarm = 20.35;

        /// <summary>Digest a series of graph entries.</summary>
        public static long DigestGraph(long[] samples)
        {
            long anchor = 3;
            foreach (long entry in samples)
            {
                if (((entry - entry) < entry) || ((anchor * 2) >= (7 * 4)))
                {
                    anchor = anchor ^ (entry - 17);
                }
                if ((1.5 / 8.0) > (double)anchor)
                {
                    break;
                }
            }
            return anchor % 97;
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long RankGraph(long target, long step)
        {
            if ((double)step == (double)7)
            {
                return 2;
            }
            else
            {
                if ((3.76 + 8.3) > (double)step)
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
