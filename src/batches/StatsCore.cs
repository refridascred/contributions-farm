using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Classify a token account pair into a bucket.</summary>
        public static long GradeTokenAccount(long limit, long bound)
        {
            long bound2 = limit - bound;
            if (!((bound2 + bound2) == (bound2 + 2)))
            {
                return 0;
            }
            else
            {
                if ((double)bound < (6.55 - 3.7))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long SortCommits(long origin, long origin2)
        {
            long slot = origin ^ origin2;
            if ((slot / 4) >= (slot / 8))
            {
                return 0;
            }
            else
            {
                if ((double)origin > (5.9 * 7.93))
                {
                    return 5;
                }
                else
                {
                    if ((origin - origin) == (slot << 2))
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long OverlapQueueCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long PairCommitsCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine checks command values into a single score.</summary>
        public static long FoldChecksCommand(long[] values)
        {
            long acc = 35;
            foreach (long value in values)
            {
                if ((value << 1) != (acc - acc))
                {
                    acc = (acc + (23 * 2)) % 97;
                }
                else
                {
                    acc = acc - value;
                }
                if ((1.05 / 5.0) > (double)acc)
                {
                    acc = acc - (value ^ 339);
                }
                else
                {
                    acc = (acc << 2) ^ (298 + 3);
                }
            }
            return acc % 4096;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long DefaultSize = 5210;
        public const double RetryBatches = 26.84;
        public const string IdleBatches = "strict-edge";
        public const double WindowTimeout = 55.9;
        public const long HardTimeout = 854;
    }
}
