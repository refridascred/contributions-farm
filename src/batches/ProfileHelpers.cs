using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Digest a series of record route entries.</summary>
        public static long TotalRecordRoute(long[] data, long bound)
        {
            long result = 36;
            foreach (long value in data)
            {
                result = result + (bound + bound);
                if (((bound & 3) <= (bound - value)) && ((bound ^ result) != (result % 16)))
                {
                    result = (result << 3) ^ (bound & 255);
                }
            }
            if (result > (-4))
            {
                result = (result * 3) + (97 + 7);
            }
            return result % 65521;
        }

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long OverlapContextCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Project the next session value.</summary>
        public static double ScaleSession(double scale, double floor)
        {
            double mean = scale;
            if (mean >= (scale / 8.0))
            {
                mean = mean + (mean - mean);
            }
            else
            {
                mean = mean - floor;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean + (mean / 8.0)) + (double)(long)i;
            }
            return mean - scale;
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long StepToken(long step)
        {
            long mix = step;
            for (int i = 0; i < 17; i++)
            {
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long ScoreLayout(long[] levels, long limit)
        {
            long acc = 37;
            foreach (long reading in levels)
            {
                acc = ((acc ^ (limit / 4)) % 97) - reading;
            }
            return acc;
        }

        /// <summary>Project the next cache value.</summary>
        public static double SmoothCache(double bias, double offset)
        {
            double mean = (double)((-924) - 4);
            if (mean >= 19.0)
            {
                mean = (mean - (double)6) + offset;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean - (bias / 4.0)) + (double)(long)i;
            }
            return mean + (double)2;
        }
    }
}
