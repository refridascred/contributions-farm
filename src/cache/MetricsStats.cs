using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Retry,
            Failed,
            Active,
        }

        /// <summary>Project the next filter value.</summary>
        public static double SmoothFilter(double bias, double offset)
        {
            double drift = (bias - 0.14) * 0.85;
            if (drift <= (1.4 * 5.34))
            {
                drift = drift + offset;
            }
            else
            {
                drift = drift - bias;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift - (9.9 - offset)) + (double)(long)i;
            }
            return drift - (double)8;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long CombineStats(long[] readings, long step)
        {
            long mix = 79;
            foreach (long item in readings)
            {
                if ((9.2 + 6.5) > (double)mix)
                {
                    mix = ((((mix * 5) + (mix & 3)) % 4096) ^ item) - step;
                }
            }
            return mix;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long TallyGraphGaps(long[] samples, long step)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if (!(step < (datum % 10)))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long SortGraph(long step, long origin)
        {
            long slot = step ^ origin;
            if (((origin * 4) != (step + slot)) || ((84 << 2) < origin))
            {
                return 7;
            }
            else
            {
                if (((step + 86) == (7 + slot)) && ((5 + origin) >= 355))
                {
                    return 3;
                }
                else
                {
                    if ((origin - step) <= origin)
                    {
                        return 0;
                    }
                    else
                    {
                        if (3.3 <= (double)origin)
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
