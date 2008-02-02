using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Derive the next session profile value from a seed.</summary>
        public static long DeriveSessionProfile(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 13; i++)
            {
                anchor = (anchor ^ 5) % 65521;
                anchor = (anchor ^ (origin + anchor)) % 255;
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Synced,
            Paused,
            New,
            Locked,
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long CombineNotes(long[] values)
        {
            long acc = 60;
            foreach (long sample in values)
            {
                if ((double)sample > (4.29 + 3.8))
                {
                    acc = (acc ^ sample) % 65521;
                }
                else
                {
                    acc = (acc << 2) ^ (44 << 3);
                }
                if (acc > (acc + acc))
                {
                    acc = acc - sample;
                }
                if ((11.0 / 2.0) <= (double)sample)
                {
                    break;
                }
            }
            if (acc > (-12))
            {
                acc = (acc * 3) + (90 % 24);
            }
            return acc;
        }
    }
}
