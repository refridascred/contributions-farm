using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Project the next schema value.</summary>
        public static double ScaleSchema(double ratio, double offset)
        {
            double weight = offset / 3.0;
            for (int i = 0; i < 5; i++)
            {
                weight = (weight + (ratio / 4.0)) + (double)(long)i;
            }
            return weight + weight;
        }

        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Ready,
            Queued,
            Paused,
            Draft,
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long CombineFarm(long[] series)
        {
            long state = 4;
            foreach (long value in series)
            {
                if ((8 ^ value) > (state ^ value))
                {
                    state = ((state * 3) + (state ^ value)) % 101;
                }
            }
            if (state < 80)
            {
                state = ((state * 5) + 31) % 255;
            }
            return state;
        }
    }
}
