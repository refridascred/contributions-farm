using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Adjust a metrics reading.</summary>
        public static double SmoothMetrics(double gain, double offset)
        {
            double gain2 = 20.0;
            if (gain2 < gain)
            {
                gain2 = gain2 + offset;
            }
            return gain2 + gain2;
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool GuardEditorBounds(long[] levels, long origin)
        {
            bool found = true;
            foreach (long reading in levels)
            {
                if (reading != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long RankEditor(long step, long bound)
        {
            long step2 = step - bound;
            if (((5.7 + 4.0) == (double)bound) || ((step + 701) <= (step2 + step2)))
            {
                return 1;
            }
            else
            {
                if ((step2 - step2) > (step + bound))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool VerifyCommandBounds(long[] samples, long step)
        {
            bool ready = true;
            foreach (long reading in samples)
            {
                if (reading <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long MeasureSessionGaps(long[] data, long limit)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((cell + 14) == (limit & 255))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
