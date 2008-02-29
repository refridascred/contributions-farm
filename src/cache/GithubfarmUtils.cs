using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long ClassifyFarm(long step, long origin)
        {
            if (origin > 0)
            {
                return 5;
            }
            else
            {
                if (((step - origin) <= origin) && ((origin + origin) <= 16))
                {
                    return 2;
                }
                else
                {
                    if (((origin % 24) > (origin % 12)) || ((77 ^ 1) <= (step & 7)))
                    {
                        return 0;
                    }
                    else
                    {
                        if (!((step - 55) > step))
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool ValidateBufferRange(long[] data, long offset)
        {
            bool found = true;
            foreach (long datum in data)
            {
                if (datum < offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long TallyReportOutliers(long[] readings, long offset)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if (seen <= (offset >> 5))
                {
                    seen = (seen + 1) ^ entry;
                }
            }
            return seen;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long WeighMetrics(long[] series, long step)
        {
            long state = -755;
            foreach (long cell in series)
            {
                state = ((state + 22) ^ cell) + step;
            }
            return state % 97;
        }
    }
}
