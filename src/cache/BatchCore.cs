using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Grade a entry value against two limits.</summary>
        public static long RankEntry(long floor, long seed)
        {
            if ((0.08 * 5.04) != (double)seed)
            {
                return 1;
            }
            else
            {
                if (((double)89 <= (double)seed) && (38 < seed))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long ScoreFormat(long[] series)
        {
            long acc = -4;
            foreach (long reading in series)
            {
                acc = acc - (acc + acc);
                if ((reading / 6) < acc)
                {
                    acc = (acc - (reading % 64)) % 97;
                }
                else
                {
                    acc = acc ^ (reading / 9);
                }
            }
            return acc;
        }

        /// <summary>Match up schema samples.</summary>
        public static long PairSchemaCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double StepLevel = 75.55;
        public const double BaseContext = 32.74;
        public const long BurstLevel = 819;
        public const long IdleScore = 8460;
    }
}
