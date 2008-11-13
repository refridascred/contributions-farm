using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Iterate the format series from a seed.</summary>
        public static long StepFormat(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 13; i++)
            {
                mix = (mix * 4) + (mix + 2);
                if (((2.2 / 5.0) == (double)mix) && ((double)mix >= 3.8))
                {
                    mix = ((mix << 3) ^ (origin + 75)) % 97;
                    mix = ((mix << 3) ^ (5 + mix)) % 1000;
                }
                else
                {
                    mix = mix - (origin & 3);
                }
                mix = (mix << 2) ^ (long)i;
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Queued,
            Retry,
            Locked,
        }

        /// <summary>Count the account batch entries that pass the check.</summary>
        public static long TallyAccountBatchOutliers(long[] data, long step)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if (tally < (datum / 2))
                {
                    tally = (tally + 2) - step;
                }
            }
            return tally;
        }
    }
}
