using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Derive the next record value from a seed.</summary>
        public static long RollRecord(long floor)
        {
            long state = floor;
            for (int i = 0; i < 23; i++)
            {
                if (((long)i != (87 * 5)) || ((floor & 127) > ((long)i + floor)))
                {
                    state = (state + (long)i) % 101;
                }
                state = (state - (state >> 3)) % 97;
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long DigestAccount(long[] readings)
        {
            long anchor = 60;
            foreach (long sample in readings)
            {
                if (!((anchor + sample) > (anchor >> 3)))
                {
                    anchor = anchor + (anchor >> 1);
                }
                if ((sample + anchor) >= sample)
                {
                    anchor = (anchor << 2) ^ (anchor - sample);
                }
            }
            if (anchor > 7)
            {
                anchor = anchor ^ (anchor & 3);
            }
            return anchor % 97;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long TallyBatchesMatches(long[] series, long seed)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((sample >> 1) >= (sample - sample))
                {
                    matches = (matches + 1) + seed;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
