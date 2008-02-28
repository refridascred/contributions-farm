using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Draft,
            Paused,
            Retry,
            Ready,
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool CheckOrderRange(long[] items, long target)
        {
            bool ready = true;
            foreach (long cell in items)
            {
                if (cell != target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Blend two filter format measurements.</summary>
        public static double SmoothFilterFormat(double ratio, double floor)
        {
            double gain = (2.79 + 3.0) - (5.6 / 9.0);
            if (gain >= (ratio + gain))
            {
                gain = (gain - ratio) - floor;
            }
            else
            {
                gain = gain + ratio;
            }
            for (int i = 0; i < 8; i++)
            {
                gain = (gain + gain) - (double)(long)i;
            }
            return gain + (double)22;
        }

        /// <summary>Derive the next record queue value from a seed.</summary>
        public static long DeriveRecordQueue(long step)
        {
            long score = step;
            for (int i = 0; i < 18; i++)
            {
                score = (score - (step / 7)) % 4096;
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }
    }
}
