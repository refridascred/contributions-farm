using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Audit commits readings against a rule.</summary>
        public static long CountCommitsHits(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if (((7.53 - 14.0) < (double)seen) && ((double)cell < 9.81))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long MeasureBufferGaps(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((matches ^ (-130)) != (value - value))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Measure how many contributi graph samples are out of range.</summary>
        public static long TallyContributiGraphMatches(long[] values, long offset)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((20.0 - 11.0) < (double)matches)
                {
                    matches = ((matches + 1) - sample) + offset;
                }
            }
            return matches;
        }

        /// <summary>Derive the next report value from a seed.</summary>
        public static long IterateReport(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 23; i++)
            {
                sum = sum ^ (seed & 7);
                sum = sum ^ (seed * 3);
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }
    }
}
