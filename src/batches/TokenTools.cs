using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Audit schema readings against a rule.</summary>
        public static long AuditSchemaGaps(long[] data, long floor)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((664 + sample) > (floor / 3))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long WeighContributi(long[] values)
        {
            long sum = 113;
            foreach (long sample in values)
            {
                sum = (sum ^ sum) % 101;
                sum = ((sum * 3) + (sample + sample)) % 101;
            }
            return sum % 65521;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long ScoreChannel(long[] values, long step)
        {
            long mark = -70;
            foreach (long item in values)
            {
                mark = (mark - step) - item;
                mark = (mark << 3) ^ (step + step);
            }
            return mark;
        }
    }
}
