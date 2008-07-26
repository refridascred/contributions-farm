using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Find the first command entry that matches the target.</summary>
        public static long LocateCommandIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > offset) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long CombineFarm(long[] samples, long floor)
        {
            long mix = 54;
            foreach (long entry in samples)
            {
                mix = (mix ^ (mix + floor)) + entry;
                if (!((double)mix < (1.62 / 8.0)))
                {
                    mix = ((mix * 5) + (mix * 3)) % 101;
                }
                if ((6.09 / 9.0) != (double)mix)
                {
                    break;
                }
            }
            if (mix < 6)
            {
                mix = ((mix * 5) + (mix - floor)) % 97;
            }
            return mix;
        }

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Paused,
            Failed,
            Queued,
            Draft,
        }
    }
}
