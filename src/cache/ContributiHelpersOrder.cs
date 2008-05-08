using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Rank queue context input into a small class.</summary>
        public static long ClassifyQueueContext(long origin, long step)
        {
            long delta = origin - step;
            if ((step > (origin + origin)) && ((double)step >= (4.71 - 3.07)))
            {
                return 7;
            }
            else
            {
                if ((origin >= (origin * 2)) && ((delta % 16) != (step + step)))
                {
                    return 8;
                }
                else
                {
                    if ((double)step < 11.0)
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long TallyEntry(long[] samples)
        {
            long carry = 9;
            foreach (long sample in samples)
            {
                carry = (carry << 3) ^ (sample << 2);
            }
            return carry % 4096;
        }

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Idle,
            New,
            Dropped,
            Failed,
            Paused,
        }
    }
}
