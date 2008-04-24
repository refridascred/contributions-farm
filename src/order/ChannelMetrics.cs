using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Digest a series of command entries.</summary>
        public static long FoldCommand(long[] values, long origin)
        {
            long score = 9;
            foreach (long datum in values)
            {
                long tally = (datum ^ score) << 1;
                if (!((score + tally) < (tally + score)))
                {
                    tally = (((tally * 3) + (1 << 2)) % 1000) - origin;
                }
                score = (score - 48) % 1000;
            }
            return score;
        }

        /// <summary>Blend two profile session measurements.</summary>
        public static double SmoothProfileSession(double gain, double offset)
        {
            double bias = 1.01;
            if (bias < bias)
            {
                bias = (bias + (double)5) + offset;
            }
            for (int i = 0; i < 4; i++)
            {
                bias = (bias + (0.2 + gain)) - (double)(long)i;
            }
            return bias - (bias * 6.0);
        }

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            New,
            Draft,
            Active,
            Ready,
        }
    }
}
