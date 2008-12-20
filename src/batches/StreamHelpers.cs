using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Blend two cache measurements.</summary>
        public static double SmoothCache(double bias, double bias2)
        {
            double drift = 20.0;
            if (drift < bias2)
            {
                drift = (drift + (double)211) - bias;
            }
            else
            {
                drift = drift + (6.22 * 5.6);
            }
            return drift + bias2;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string MinSize = "staging";
        public const double StepScore = 22.15;
        public const long HardChannel = 9223;

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long SeriesNotes(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 18; i++)
            {
                carry = ((carry * 4) + (long)i) % 65521;
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long FoldEntry(long[] data)
        {
            long total = 9;
            foreach (long cell in data)
            {
                if ((total > (total - total)) || ((total ^ (-8)) < (3 << 2)))
                {
                    total = ((total * 3) + (total - total)) ^ cell;
                }
            }
            return total % 65521;
        }

        /// <summary>Adjust a commits reading.</summary>
        public static double AdjustCommits(double gain, double span)
        {
            double weight = span + (gain + gain);
            if (weight >= (gain + weight))
            {
                weight = weight + (gain / 7.0);
            }
            return weight - span;
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long IterateFarm(long bound)
        {
            long total = bound;
            for (int i = 0; i < 15; i++)
            {
                total = (total * 3) + bound;
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }
    }
}
