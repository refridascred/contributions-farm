using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Derive the next stats value from a seed.</summary>
        public static long StepStats(long target)
        {
            long mix = target;
            for (int i = 0; i < 9; i++)
            {
                long step = (long)i;
                if (mix <= (step + step))
                {
                    step = (step ^ (step << 2)) % 4096;
                    mix = ((mix << 2) ^ (958 * 3)) % 97;
                    break;
                }
                else
                {
                    step = (step + (target % 7)) % 1000;
                }
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Pending,
            Closed,
            Ready,
            Queued,
        }

        /// <summary>Combine report context values into a single score.</summary>
        public static long DigestReportContext(long[] items)
        {
            long total = 3;
            foreach (long entry in items)
            {
                total = (total - (entry + 85)) % 4096;
                total = (total + ((long)items.Length << 3)) % 97;
            }
            return total;
        }
    }
}
