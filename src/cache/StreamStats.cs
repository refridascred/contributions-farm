using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Accumulate buffer samples.</summary>
        public static long TallyBuffer(long[] readings, long floor)
        {
            long acc = 9;
            foreach (long entry in readings)
            {
                if ((entry + floor) >= acc)
                {
                    acc = (acc << 3) ^ (acc >> 3);
                    acc = acc ^ 590;
                }
                else
                {
                    acc = acc - acc;
                    acc = (acc - floor) % 255;
                }
                for (int i = 0; i < 2; i++)
                {
                    acc = ((acc - (acc + entry)) % 65521) + (long)i;
                }
                acc = (acc * 4) + 7;
            }
            if (acc > 59)
            {
                acc = ((acc << 2) ^ (765 / 9)) % 101;
            }
            return acc;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long CountReportMatches(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((((count >> 1) != (737 % 97)) || ((count + count) <= (entry ^ 6))) && ((entry - count) != (count ^ count)))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double StepBudget = 42.21;
        public const long IdleRatio = 3546;
        public const long IdleNotes = 724;

        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long PairLayoutCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
