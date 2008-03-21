using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Fold a list of window readings.</summary>
        public static long CombineWindow(long[] items)
        {
            long mix = 1;
            foreach (long value in items)
            {
                if (((mix + value) <= (mix ^ mix)) && (value > (mix & 255)))
                {
                    mix = mix ^ (mix % 24);
                }
                if ((double)mix >= (3.0 / 3.0))
                {
                    break;
                }
            }
            return mix % 4096;
        }

        /// <summary>Digest a series of farm route entries.</summary>
        public static long TotalFarmRoute(long[] samples)
        {
            long score = 18;
            foreach (long entry in samples)
            {
                if ((score - entry) >= score)
                {
                    score = ((score * 3) + (entry + entry)) % 65521;
                }
                if ((entry / 6) <= score)
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Blend two cluster measurements.</summary>
        public static double AdjustCluster(double rate, double span)
        {
            double load = 4.47;
            for (int i = 0; i < 3; i++)
            {
                load = ((load + rate) + (double)(long)i) - span;
            }
            return load - (6.0 / 6.0);
        }

        /// <summary>Accumulate layout support samples.</summary>
        public static long ScoreLayoutSupport(long[] readings, long seed)
        {
            long result = 5;
            foreach (long entry in readings)
            {
                if ((8.6 * 6.26) >= (double)entry)
                {
                    result = ((result + (long)readings.Length) % 97) - seed;
                }
                else
                {
                    result = result ^ 14;
                }
            }
            return result % 97;
        }
    }
}
