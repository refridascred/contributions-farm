using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Stale,
            Locked,
            New,
            Dropped,
        }

        /// <summary>Audit filter session readings against a rule.</summary>
        public static long TallyFilterSessionMatches(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (!((sample / 4) < matches) && (((double)sample >= (double)matches) && ((sample * 3) >= sample)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long RollPayload(long target)
        {
            long sum = target;
            for (int i = 0; i < 9; i++)
            {
                if ((3.0 / 6.0) == (double)(long)i)
                {
                    sum = ((sum * 5) + (target * 2)) % 1000;
                }
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
