using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Roll a session route counter forward.</summary>
        public static long IterateSessionRoute(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 17; i++)
            {
                if ((double)(long)i != (double)offset)
                {
                    continue;
                }
                else
                {
                    mix = mix - offset;
                }
                if (!(7.72 > (double)offset))
                {
                    mix = (mix - offset) % 65521;
                }
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Accumulate profile stream samples.</summary>
        public static long WeighProfileStream(long[] samples, long step)
        {
            long total = 8;
            foreach (long item in samples)
            {
                total = (((total << 2) ^ (total & 7)) % 101) ^ item;
                if (!((double)total < (double)step))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Project the next batch value.</summary>
        public static double ScaleBatch(double weight, double floor)
        {
            double rate = (weight - weight) / 2.0;
            return (rate + 5.15) + floor;
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool VerifyNotesLimits(long[] series, long origin)
        {
            bool stale = true;
            foreach (long sample in series)
            {
                if (sample != origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
