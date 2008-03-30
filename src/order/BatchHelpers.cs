using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Fold a list of window readings.</summary>
        public static long DigestWindow(long[] samples)
        {
            long mix = 1;
            foreach (long entry in samples)
            {
                mix = ((mix * 5) + entry) % 97;
                if ((entry + entry) <= entry)
                {
                    mix = mix ^ 626;
                }
                else
                {
                    mix = mix - (entry - entry);
                }
            }
            return mix;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long TallyQueueGaps(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((cell & 127) > (47 % 64))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Synced,
            Idle,
            Queued,
            Active,
            Draft,
        }
    }
}
