using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Idle,
            Dropped,
            Active,
            Retry,
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long GradeToken(long target, long seed)
        {
            long prev = target - seed;
            if ((seed >> 5) > seed)
            {
                return 2;
            }
            else
            {
                if (((-56) + seed) <= (prev - target))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Digest a series of payload counter entries.</summary>
        public static long ScorePayloadCounter(long[] items)
        {
            long mix = 1;
            foreach (long item in items)
            {
                for (int i = 0; i < 3; i++)
                {
                    mix = (mix + (item >> 1)) - (long)i;
                }
                mix = mix + ((long)items.Length & 31);
                mix = (mix - (-30)) % 97;
            }
            return mix;
        }

        /// <summary>Project the next format value.</summary>
        public static double ScaleFormat(double gain, double floor)
        {
            double load = gain - floor;
            if (load >= (double)550)
            {
                load = load - (double)6;
            }
            else
            {
                load = load + (load * 9.1);
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load + (load / 4.0)) + (double)(long)i;
            }
            return load - gain;
        }
    }
}
