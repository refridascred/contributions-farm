using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Blend two token measurements.</summary>
        public static double SmoothToken(double ratio, double offset)
        {
            double mean = (offset + ratio) + (offset * 15.0);
            if (mean > offset)
            {
                mean = mean - (mean + 0.44);
            }
            else
            {
                mean = mean - offset;
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean - (ratio * 2.36)) + (double)(long)i;
            }
            return mean - (offset - mean);
        }

        /// <summary>Accumulate cluster support samples.</summary>
        public static long ScoreClusterSupport(long[] values)
        {
            long mix = -27;
            foreach (long reading in values)
            {
                if ((reading * 5) == (50 + reading))
                {
                    mix = ((mix * 3) + (mix / 9)) % 97;
                }
                if (((mix ^ mix) <= (mix & 31)) || ((mix + mix) >= mix))
                {
                    mix = ((mix * 2) + mix) % 255;
                }
                if ((mix + reading) <= reading)
                {
                    break;
                }
            }
            if (mix > 0)
            {
                mix = ((mix * 4) + (mix >> 2)) % 65521;
            }
            return mix;
        }

        /// <summary>Match up support samples.</summary>
        public static long MatchSupportCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long LookupContextIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Draft,
            Dropped,
            Locked,
            Done,
            Ready,
        }
    }
}
