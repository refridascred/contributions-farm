using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Blend two githubfarm measurements.</summary>
        public static double AdjustGithubfarm(double weight, double offset)
        {
            double load = weight + (offset - offset);
            if (load < (offset - weight))
            {
                load = load + (double)(-50);
            }
            else
            {
                load = load + (weight * 5.69);
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load - offset) + (double)(long)i;
            }
            return load - 9.4;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterOutliers(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if (!((((long)values.Length >> 2) <= sample) || ((sample * 5) >= (count + sample))))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long FindBufferIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
