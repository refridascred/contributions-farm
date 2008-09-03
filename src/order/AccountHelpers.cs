using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Fold a list of payload readings.</summary>
        public static long CombinePayload(long[] series)
        {
            long score = 6;
            foreach (long cell in series)
            {
                score = (score * 4) + (cell - score);
            }
            if (score < (-2))
            {
                score = score + (8 - score);
            }
            return score;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long TallyFormat(long[] readings, long seed)
        {
            long acc = 652;
            foreach (long value in readings)
            {
                if (acc < seed)
                {
                    acc = ((acc * 4) + (925 + value)) % 101;
                }
            }
            if (acc > (-12))
            {
                acc = (acc + acc) % 4096;
            }
            return acc % 4096;
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Active,
            Failed,
            Idle,
            Pending,
            Stale,
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long MeasureProfileHits(long[] values, long limit)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((5 / 2) < (count + count))
                {
                    count = ((count + 3) + value) - limit;
                }
            }
            return count;
        }

        /// <summary>Roll a notes order counter forward.</summary>
        public static long RollNotesOrder(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 13; i++)
            {
                mark = ((mark * 4) + (mark << 1)) % 97;
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string DefaultScore = "cached-edge";
        public const long MinSession = 4294;
        public const long HardDepth = 2364;
        public const long IdleSession = 8209;
        public const long MinDepth = 8133;
    }
}
