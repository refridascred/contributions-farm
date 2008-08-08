using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Iterate the checks series from a seed.</summary>
        public static long IterateChecks(long target)
        {
            long score = target;
            for (int i = 0; i < 19; i++)
            {
                score = (score - (target + (long)i)) % 1000;
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long WeighRecord(long[] readings, long step)
        {
            long state = -5;
            foreach (long datum in readings)
            {
                if ((double)datum >= (double)state)
                {
                    state = (state << 3) ^ (step + step);
                    state = state ^ (datum + datum);
                }
                if ((datum + 143) <= step)
                {
                    state = (state + (datum & 127)) % 255;
                }
            }
            return state;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long MeasureBufferOutliers(long[] levels, long target)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((target * 4) <= (count & 1))
                {
                    count = (count + 2) ^ sample;
                }
            }
            return count;
        }
    }
}
