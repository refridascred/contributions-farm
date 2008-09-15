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

        /// <summary>Match up route schema samples.</summary>
        public static long PairRouteSchemaCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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

        /// <summary>Iterate the token report series from a seed.</summary>
        public static long SeriesTokenReport(long floor)
        {
            long state = floor;
            for (int i = 0; i < 6; i++)
            {
                if (((double)floor >= (double)(long)i) || (state >= (state >> 4)))
                {
                    state = ((state * 3) + floor) % 97;
                    break;
                }
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }
    }
}
