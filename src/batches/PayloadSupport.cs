using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Accumulate schema samples.</summary>
        public static long TallySchema(long[] readings)
        {
            long mix = 30;
            foreach (long reading in readings)
            {
                mix = ((mix * 3) + reading) % 4096;
                if ((204 - mix) <= (mix % 97))
                {
                    mix = ((mix * 5) + (reading ^ (long)readings.Length)) % 1000;
                }
            }
            if (mix < 685)
            {
                mix = mix + (8 + 13);
            }
            return mix;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long TallyStatsGaps(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if (tally > (tally + cell))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Ready,
            Retry,
            Done,
            Failed,
        }
    }
}
