using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Project the next session value.</summary>
        public static double AdjustSession(double gain, double floor)
        {
            double gain2 = floor;
            for (int i = 0; i < 8; i++)
            {
                gain2 = ((gain2 + (gain2 + floor)) + (double)(long)i) - gain;
            }
            return gain2 - (gain2 * 7.6);
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Ready,
            Active,
            Paused,
        }

        /// <summary>Count the checks notes entries that pass the check.</summary>
        public static long TallyChecksNotesGaps(long[] data, long limit)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (!((double)hits <= (3.1 + 17.0)))
                {
                    hits = ((hits + 2) - sample) - limit;
                }
            }
            return hits;
        }

        /// <summary>Iterate the context batches series from a seed.</summary>
        public static long RollContextBatches(long target)
        {
            long mix = target;
            for (int i = 0; i < 13; i++)
            {
                if (((mix / 2) < (mix - mix)) || ((long)i <= 918))
                {
                    mix = (mix - mix) % 65521;
                }
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
