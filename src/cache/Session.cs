using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Audit layout readings against a rule.</summary>
        public static long TallyLayoutGaps(long[] samples)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((cell + 98) >= ((-6) + matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long StepRecord(long target)
        {
            long sum = target;
            for (int i = 0; i < 20; i++)
            {
                sum = sum ^ ((long)i << 3);
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long CountRecordMatches(long[] levels)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if (((23 % 24) < (matches >> 5)) || ((entry < (entry ^ (-29))) || ((double)(long)levels.Length == (1.33 * 7.97))))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long WeighWindow(long[] items)
        {
            long state = 8;
            foreach (long datum in items)
            {
                if ((state <= 68) && ((state & 15) == (long)items.Length))
                {
                    state = ((state ^ 31) % 4096) + datum;
                }
            }
            return state;
        }
    }
}
