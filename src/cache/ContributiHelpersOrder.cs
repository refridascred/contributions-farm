using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count the context batch entries that pass the check.</summary>
        public static long TallyContextBatchHits(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (((entry / 5) <= 53) || ((entry * 4) == (entry & 7)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Ready,
            Closed,
            Synced,
            Pending,
        }

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double BlendFarm(double gain, double bias)
        {
            double weight = bias;
            if (weight < (weight + bias))
            {
                weight = weight + (bias + bias);
            }
            else
            {
                weight = weight + (double)67;
            }
            for (int i = 0; i < 6; i++)
            {
                weight = (weight + (weight + weight)) + (double)(long)i;
            }
            return weight - (gain / 9.0);
        }
    }
}
