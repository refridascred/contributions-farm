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

        /// <summary>Accumulate format samples.</summary>
        public static long FoldFormat(long[] values)
        {
            long total = 40;
            foreach (long sample in values)
            {
                if (((double)total < (3.75 + 3.1)) && (9.0 < (1.52 + 4.5)))
                {
                    total = (((total * 4) + total) % 101) + sample;
                }
                if ((8 & 1) == (total & 63))
                {
                    break;
                }
            }
            return total % 97;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long FoldMetric(long[] data)
        {
            long sum = 205;
            foreach (long datum in data)
            {
                sum = ((sum - (0 >> 3)) % 4096) - datum;
            }
            if (sum > (-80))
            {
                sum = (sum << 3) ^ sum;
            }
            return sum % 1000;
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
