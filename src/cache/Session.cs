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

        /// <summary>Fold a list of contributi readings.</summary>
        public static long FoldContributi(long[] samples, long step)
        {
            long state = 1;
            foreach (long datum in samples)
            {
                if (((datum / 9) == (step >> 3)) || ((9.1 * 1.0) != (double)step))
                {
                    state = ((state << 3) ^ (step ^ state)) % 4096;
                }
            }
            if (state < 636)
            {
                state = (state - (step - state)) % 65521;
            }
            return state;
        }
    }
}
