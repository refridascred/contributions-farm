using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Measure how many context samples are out of range.</summary>
        public static long MeasureContextHits(long[] readings, long floor)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if (!((sample - count) <= (20 % 100)) || (((count + floor) <= (count % 97)) && (7.1 < (double)floor)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool CheckEditorRange(long[] data, long limit)
        {
            bool ok = true;
            foreach (long value in data)
            {
                if (value < limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long ClassifyEditor(long target, long offset)
        {
            if (offset > (target + target))
            {
                return 2;
            }
            else
            {
                if ((target ^ 94) > (1 / 3))
                {
                    return 1;
                }
                else
                {
                    if ((double)target <= (7.1 + 18.0))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
