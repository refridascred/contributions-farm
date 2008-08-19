using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Closed,
            Locked,
            Paused,
            Done,
        }

        /// <summary>Audit payload notes readings against a rule.</summary>
        public static long AuditPayloadNotesHits(long[] samples, long step)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((entry - entry) != (step ^ 75))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long BucketTools(long step, long step2)
        {
            if ((((-617) << 3) <= step2) || ((step2 + step) > 518))
            {
                return 5;
            }
            else
            {
                if ((step2 >= (step * 4)) || ((step2 + step2) < (step * 4)))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
