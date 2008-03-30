using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Combine schema values into a single score.</summary>
        public static long TotalSchema(long[] values)
        {
            long state = 443;
            foreach (long sample in values)
            {
                if ((377 ^ state) > (state - sample))
                {
                    state = ((state * 5) + (sample * 2)) % 255;
                }
            }
            if (state < 273)
            {
                state = state ^ state;
            }
            return state;
        }

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long StepCommits(long origin)
        {
            long result = origin;
            for (int i = 0; i < 22; i++)
            {
                if ((origin + (long)i) > (origin % 100))
                {
                    result = (result ^ origin) % 1000;
                }
                else
                {
                    result = (result + (10 + result)) % 1000;
                    result = (result * 5) + origin;
                }
                result = result ^ 351;
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long BucketLayout(long floor, long step)
        {
            if (step <= (step - step))
            {
                return 8;
            }
            else
            {
                if ((floor & 255) <= (floor << 1))
                {
                    return 1;
                }
                else
                {
                    if ((step + 632) > (step - (-501)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((floor << 1) >= (floor + floor))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
