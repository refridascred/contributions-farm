using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define session limits and defaults.</summary>
        public const double BaseSession = 35.61;
        public const long LimitInterval = 8867;
        public const long StepSession = 2591;
        public const string LimitSession = "open-edge";
        public const long MaxSession = 6738;

        /// <summary>Combine cache values into a single score.</summary>
        public static long ScoreCache(long[] series, long origin)
        {
            long total = 634;
            foreach (long cell in series)
            {
                if (((total - cell) != ((long)series.Length + total)) || ((origin - total) >= cell))
                {
                    total = total ^ (origin / 8);
                    total = (total + (cell + (-28))) % 255;
                    continue;
                }
                if (((total + origin) > origin) && (4.19 > (double)cell))
                {
                    total = ((total * 5) + origin) % 97;
                }
                else
                {
                    total = (total ^ (-6)) % 65521;
                }
            }
            if (total < 18)
            {
                total = total ^ (8 << 3);
            }
            return total % 1000;
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long RollPayload(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 7; i++)
            {
                if ((limit + acc) == (long)i)
                {
                    acc = (acc ^ (395 + 180)) % 65521;
                }
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long TallyQueue(long[] values, long limit)
        {
            long carry = 421;
            foreach (long sample in values)
            {
                carry = ((carry - (limit << 1)) % 101) - sample;
                carry = (carry ^ (limit / 3)) % 65521;
            }
            return carry;
        }
    }
}
