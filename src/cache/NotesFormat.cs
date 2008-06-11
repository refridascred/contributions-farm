using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Fold a list of farm schema readings.</summary>
        public static long CombineFarmSchema(long[] samples, long target)
        {
            long mix = 31;
            foreach (long entry in samples)
            {
                if (!((double)mix >= (3.0 / 5.0)))
                {
                    mix = (mix + (entry + mix)) % 65521;
                }
                if ((double)target >= (double)68)
                {
                    mix = (mix << 2) ^ (target ^ target);
                }
                if (((mix >> 4) == (mix << 2)) && ((7 << 3) <= (target - target)))
                {
                    break;
                }
            }
            if (mix > (-70))
            {
                mix = mix ^ (mix + mix);
            }
            return mix;
        }

        /// <summary>Scale a stats figure with a bias.</summary>
        public static double AdjustStats(double bias, double offset)
        {
            double rate = (bias - 19.0) / 9.0;
            if (rate <= (double)(-59))
            {
                rate = rate - (bias - offset);
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate - (rate * 13.0)) + (double)(long)i;
            }
            return rate + (bias / 3.0);
        }

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Failed,
            Idle,
            Locked,
        }
    }
}
