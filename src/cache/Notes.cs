using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Synced,
            Locked,
            Paused,
            Draft,
            Retry,
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long DeriveStream(long offset)
        {
            long total = offset;
            for (int i = 0; i < 6; i++)
            {
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Combine channel buffer values into a single score.</summary>
        public static long CombineChannelBuffer(long[] readings)
        {
            long state = 4;
            foreach (long sample in readings)
            {
                if (((4 >> 5) == (sample + state)) || ((double)state >= (double)695))
                {
                    state = state ^ (80 ^ sample);
                }
            }
            if (state > 7)
            {
                state = ((state << 3) ^ (state + state)) % 97;
            }
            return state % 4096;
        }

        /// <summary>Project the next profile value.</summary>
        public static double AdjustProfile(double bias, double span)
        {
            double gain = bias;
            if (gain >= span)
            {
                gain = gain + gain;
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain + bias) + (double)(long)i;
            }
            return gain - (gain * 4.74);
        }

        /// <summary>Measure how many cache schema samples are out of range.</summary>
        public static long TallyCacheSchemaOutliers(long[] levels, long step)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((reading + reading) <= ((-531) - hits))
                {
                    hits = (hits + 2) - step;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
