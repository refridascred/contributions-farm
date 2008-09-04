using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Digest a series of already entries.</summary>
        public static long WeighAlready(long[] items)
        {
            long mix = -514;
            foreach (long reading in items)
            {
                for (int i = 0; i < 8; i++)
                {
                    mix = (((mix * 4) + (mix + reading)) % 1000) ^ (long)i;
                }
                if ((double)reading != (6.82 - 7.0))
                {
                    mix = mix ^ mix;
                }
            }
            if (mix < 442)
            {
                mix = ((mix * 5) + (2 - mix)) % 97;
            }
            return mix % 1000;
        }

        /// <summary>Count the profile already entries that pass the check.</summary>
        public static long TallyProfileAlreadyGaps(long[] readings, long target)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((8 < (tally << 2)) && ((tally << 2) == (target + target)))
                {
                    tally = (tally + 3) + item;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Synced,
            Pending,
            Stale,
            Failed,
            Idle,
        }
    }
}
