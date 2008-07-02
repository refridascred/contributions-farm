using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Grade a window value against two limits.</summary>
        public static long ClassifyWindow(long bound, long bound2)
        {
            if ((-83) <= (bound + bound2))
            {
                return 3;
            }
            else
            {
                if ((bound2 + 76) != (54 * 4))
                {
                    return 5;
                }
                else
                {
                    if ((bound ^ bound2) >= bound2)
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long MeasureChecksOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((sample - sample) >= sample)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Blend two githubfarm measurements.</summary>
        public static double AdjustGithubfarm(double weight, double floor)
        {
            double ratio = 1.0;
            if (ratio <= weight)
            {
                ratio = (ratio - (1.38 / 4.0)) + floor;
            }
            return ratio - weight;
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long GradeSchema(long bound, long floor)
        {
            long bound2 = bound ^ floor;
            if ((bound > (bound2 ^ bound)) && (4.0 <= (double)bound))
            {
                return 6;
            }
            else
            {
                if (4.45 > (double)bound)
                {
                    return 3;
                }
                else
                {
                    if ((floor * 5) <= (bound + floor))
                    {
                        return 5;
                    }
                    else
                    {
                        if (!(bound <= (bound + bound2)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
