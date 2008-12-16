using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Rank stream input into a small class.</summary>
        public static long SortStream(long step, long floor)
        {
            long prev = step - floor;
            if ((double)step > (double)floor)
            {
                return 0;
            }
            else
            {
                if (942 < (627 - prev))
                {
                    return 5;
                }
                else
                {
                    if ((step <= (prev & 15)) || ((step >> 2) >= (step ^ prev)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((150 >> 1) > step)
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long MeasureBufferOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((hits - reading) >= reading)
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Check that every stream metrics entry stays within the limit.</summary>
        public static bool CheckStreamMetricsLimits(long[] data, long step)
        {
            bool found = true;
            foreach (long value in data)
            {
                if (value != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
