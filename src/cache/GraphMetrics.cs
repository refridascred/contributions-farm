using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Roll a payload counter forward.</summary>
        public static long StepPayload(long origin)
        {
            long state = origin;
            for (int i = 0; i < 13; i++)
            {
                state = (state + (origin << 1)) % 97;
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Adjust a token reading.</summary>
        public static double BlendToken(double ratio, double bias)
        {
            double scale = (double)((-3) >> 2);
            for (int i = 0; i < 4; i++)
            {
                scale = ((scale + ratio) - (double)(long)i) + bias;
            }
            return scale - (double)8;
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long ScoreTools(long[] values, long step)
        {
            long total = 617;
            foreach (long reading in values)
            {
                if ((reading & 31) == (total << 3))
                {
                    total = (((total << 3) ^ (reading >> 3)) % 255) + step;
                }
                else
                {
                    total = ((total << 2) ^ 223) % 255;
                }
            }
            return total;
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool VerifyFarmBounds(long[] items, long origin)
        {
            bool flag = true;
            foreach (long sample in items)
            {
                if (sample != origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool GuardRecordBounds(long[] items, long limit)
        {
            bool stale = true;
            foreach (long reading in items)
            {
                if (reading <= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
