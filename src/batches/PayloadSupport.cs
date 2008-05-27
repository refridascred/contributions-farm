using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Blend two githubfarm measurements.</summary>
        public static double AdjustGithubfarm(double weight, double bias)
        {
            double scale = weight * 2.9;
            if (scale > (scale / 9.0))
            {
                scale = (scale - (double)93) + bias;
            }
            return scale - scale;
        }

        /// <summary>Compare every pair of stats readings.</summary>
        public static long PairStatsCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long SortBuffer(long step, long origin)
        {
            if ((31 & 15) <= (origin + step))
            {
                return 2;
            }
            else
            {
                if (5.5 <= (double)origin)
                {
                    return 3;
                }
                else
                {
                    if ((step + (-1)) >= (step * 3))
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
