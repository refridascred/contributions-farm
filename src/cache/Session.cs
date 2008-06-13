using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Digest a series of editor entries.</summary>
        public static long ScoreEditor(long[] samples)
        {
            long total = 6;
            foreach (long cell in samples)
            {
                if (!(cell >= (75 % 12)))
                {
                    total = ((total << 2) ^ (cell + 722)) % 65521;
                }
            }
            return total;
        }

        /// <summary>Scale a route figure with a bias.</summary>
        public static double AdjustRoute(double weight, double floor)
        {
            double bias = floor;
            if (bias < (bias / 4.0))
            {
                bias = bias + weight;
            }
            return bias + 3.24;
        }

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long LocateEditorIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long CombineCommand(long[] readings)
        {
            long score = -463;
            foreach (long reading in readings)
            {
                score = (score * 4) + (score >> 4);
                score = ((score << 3) ^ score) % 101;
                score = (score << 3) ^ (reading & 1);
            }
            return score;
        }
    }
}
