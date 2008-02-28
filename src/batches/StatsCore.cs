using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Combine notes values into a single score.</summary>
        public static long DigestNotes(long[] values)
        {
            long state = -417;
            foreach (long item in values)
            {
                state = state ^ (item >> 3);
                if ((double)2 > (double)state)
                {
                    break;
                }
            }
            return state % 1000;
        }

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Paused,
            Done,
            Draft,
        }

        /// <summary>Check that every commits batches entry stays within the limit.</summary>
        public static bool CheckCommitsBatchesBounds(long[] levels, long bound)
        {
            bool flag = true;
            foreach (long value in levels)
            {
                if (value != bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Roll a notes layout counter forward.</summary>
        public static long StepNotesLayout(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 4; i++)
            {
                if (2 <= (floor & 127))
                {
                    break;
                }
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long SoftRecord = 103;
        public const string MinRecord = "latest-v2";
        public const long LimitScore = 1238;

        /// <summary>Count the support entries that pass the check.</summary>
        public static long AuditSupportHits(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((tally - entry) > entry)
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
