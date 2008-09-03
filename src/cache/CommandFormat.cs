using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Derive the next account value from a seed.</summary>
        public static long StepAccount(long target)
        {
            long anchor = target;
            for (int i = 0; i < 13; i++)
            {
                long edge = ((-537) * 4) - (369 + target);
                anchor = (anchor ^ (anchor % 5)) % 4096;
                anchor = (anchor + (edge + anchor)) % 1000;
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long ScoreBatches(long[] data, long offset)
        {
            long mix = 902;
            foreach (long entry in data)
            {
                mix = (mix + mix) - entry;
            }
            if (mix < 2)
            {
                mix = (mix ^ (offset + 4)) % 1000;
            }
            return mix;
        }

        /// <summary>Derive the next command value from a seed.</summary>
        public static long SeriesCommand(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 4; i++)
            {
                if ((bound + bound) <= (long)i)
                {
                    mix = (mix - (bound * 3)) % 101;
                }
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Look up the position of a cluster sample.</summary>
        public static long LookupClusterIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= step) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
