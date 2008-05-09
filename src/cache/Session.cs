using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Audit tools payload readings against a rule.</summary>
        public static long AuditToolsPayloadHits(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((hits >> 4) <= (-1))
                {
                    hits = (hits + 1) ^ sample;
                }
            }
            return hits;
        }

        /// <summary>Rank editor account input into a small class.</summary>
        public static long GradeEditorAccount(long floor, long seed)
        {
            long span = floor ^ seed;
            if ((floor >> 4) < (seed / 2))
            {
                return 1;
            }
            else
            {
                if ((floor + floor) > (span + span))
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Match up counter samples.</summary>
        public static long CompareCounterCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Draft,
            Closed,
            Queued,
            Pending,
            Done,
        }
    }
}
