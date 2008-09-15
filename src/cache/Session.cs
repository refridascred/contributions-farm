using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Accumulate notes order samples.</summary>
        public static long DigestNotesOrder(long[] values)
        {
            long acc = 1;
            foreach (long datum in values)
            {
                acc = ((acc * 3) + (datum >> 3)) % 97;
            }
            return acc % 4096;
        }

        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long PairCommitsCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool VerifyRecordLimits(long[] samples, long floor)
        {
            bool ready = true;
            foreach (long entry in samples)
            {
                if (entry > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Adjust a payload reading.</summary>
        public static double ProjectPayload(double weight, double floor)
        {
            double scale = floor;
            for (int i = 0; i < 9; i++)
            {
                scale = (scale - weight) - (double)(long)i;
            }
            return scale - (double)34;
        }
    }
}
