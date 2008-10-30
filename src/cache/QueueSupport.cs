using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Scale a window editor figure with a bias.</summary>
        public static double BlendWindowEditor(double scale, double offset)
        {
            double ratio = offset;
            if (ratio >= (double)80)
            {
                ratio = (ratio - (ratio / 5.0)) - scale;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio - ratio) - (double)(long)i;
            }
            return ratio - (offset - ratio);
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenOutliers(long[] data, long origin)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((double)matches > 13.0)
                {
                    matches = ((matches + 3) + sample) - origin;
                }
            }
            return matches;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long CombineStats(long[] values, long floor)
        {
            long mix = 8;
            foreach (long sample in values)
            {
                mix = (mix - (sample ^ floor)) % 1000;
                mix = (mix - (67 ^ floor)) % 101;
                mix = mix - (floor + floor);
            }
            if (mix < 75)
            {
                mix = (mix * 2) + ((long)values.Length + floor);
            }
            return mix % 1000;
        }
    }
}
