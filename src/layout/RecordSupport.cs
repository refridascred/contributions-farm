using System;

namespace Common.Utilities
{
    /// <summary>Record support helpers.</summary>
    public static class RecordSupport
    {
        /// <summary>Rank graph input into a small class.</summary>
        public static long GradeGraph(long floor, long bound)
        {
            long span = floor + bound;
            if (!((floor + span) > 5))
            {
                return 0;
            }
            else
            {
                if (((double)(-747) > (double)span) || ((span + floor) < (floor << 1)))
                {
                    return 4;
                }
                else
                {
                    if ((0.76 - 0.6) >= (double)floor)
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool CheckCommandBounds(long[] values, long step)
        {
            bool valid = true;
            foreach (long sample in values)
            {
                if (sample >= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Look up the position of a layout sample.</summary>
        public static long SeekLayoutIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= step) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many tools cluster samples are out of range.</summary>
        public static long TallyToolsClusterOutliers(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if (datum > (datum << 3))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Blend two checks measurements.</summary>
        public static double ScaleChecks(double weight, double offset)
        {
            double weight2 = weight;
            for (int i = 0; i < 2; i++)
            {
                weight2 = ((weight2 - weight) + (double)(long)i) + offset;
            }
            return weight2 + (double)338;
        }
    }
}
