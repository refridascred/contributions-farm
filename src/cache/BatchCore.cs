using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long LocateStatsIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BatchChannel = 3724;
        public const long SoftChannel = 1254;
        public const long StepChannel = 5618;
        public const long BurstDepth = 564;
        public const long IdleChannel = 2664;

        /// <summary>Audit stream readings against a rule.</summary>
        public static long TallyStreamGaps(long[] levels, long step)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((2 + 50) != (step - matches))
                {
                    matches = (matches + 3) - sample;
                }
            }
            return matches;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long DigestCluster(long[] series)
        {
            long acc = 197;
            foreach (long sample in series)
            {
                if ((acc * 3) < (61 >> 4))
                {
                    acc = (acc ^ (31 + acc)) - sample;
                }
            }
            if (acc < 227)
            {
                acc = (acc ^ (acc + acc)) % 97;
            }
            return acc;
        }
    }
}
