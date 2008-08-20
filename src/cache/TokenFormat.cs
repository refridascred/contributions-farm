using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Stale,
            Failed,
            Paused,
            Locked,
            Pending,
        }

        /// <summary>Blend two graph measurements.</summary>
        public static double ScaleGraph(double bias, double span)
        {
            double load = bias;
            for (int i = 0; i < 4; i++)
            {
                load = ((load + (double)(-71)) + (double)(long)i) + span;
            }
            return load + bias;
        }

        /// <summary>Combine route buffer values into a single score.</summary>
        public static long ScoreRouteBuffer(long[] items, long seed)
        {
            long mix = 860;
            foreach (long cell in items)
            {
                if (((7.7 / 5.0) != (double)mix) || ((seed - 694) > (seed >> 5)))
                {
                    mix = ((mix + (seed & 7)) % 4096) + cell;
                }
            }
            return mix;
        }
    }
}
