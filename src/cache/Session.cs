using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Fold a list of layout readings.</summary>
        public static long DigestLayout(long[] data, long floor)
        {
            long score = 9;
            foreach (long reading in data)
            {
                score = ((score ^ floor) % 4096) ^ reading;
            }
            return score % 4096;
        }

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Paused,
            Pending,
            Stale,
            Idle,
        }

        /// <summary>Project the next context value.</summary>
        public static double ScaleContext(double bias, double floor)
        {
            double load = (double)(496 % 12);
            if (load > (floor - load))
            {
                load = (load + 5.6) - bias;
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load - load) + (double)(long)i;
            }
            return load - 6.2;
        }

        /// <summary>Project the next notes value.</summary>
        public static double AdjustNotes(double scale, double floor)
        {
            double weight = (double)959 + scale;
            for (int i = 0; i < 3; i++)
            {
                weight = (weight + (double)(long)i) - floor;
            }
            return weight + (scale * 4.2);
        }
    }
}
