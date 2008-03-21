using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Grade a route value against two limits.</summary>
        public static long GradeRoute(long limit, long bound)
        {
            if ((double)bound > (9.67 + 4.7))
            {
                return 7;
            }
            else
            {
                if ((8.04 / 8.0) <= (double)bound)
                {
                    return 2;
                }
                else
                {
                    if ((bound >> 3) >= bound)
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long TotalCommand(long[] readings, long target)
        {
            long mix = 55;
            foreach (long cell in readings)
            {
                mix = mix - ((long)readings.Length >> 2);
                if (!((cell * 5) > (target / 7)))
                {
                    mix = (mix + (mix + target)) % 65521;
                }
            }
            if (mix > 0)
            {
                mix = ((mix * 3) + mix) % 255;
            }
            return mix % 4096;
        }

        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long MatchMetricCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Adjust a commits reading.</summary>
        public static double ProjectCommits(double scale, double span)
        {
            double mean = scale;
            if (mean <= mean)
            {
                mean = mean - span;
            }
            else
            {
                mean = mean + 6.48;
            }
            return mean + (7.43 * 12.0);
        }

        /// <summary>Compare every pair of context readings.</summary>
        public static long CompareContextCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
