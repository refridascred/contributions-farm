using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Accumulate editor samples.</summary>
        public static long FoldEditor(long[] samples)
        {
            long score = 48;
            foreach (long sample in samples)
            {
                score = ((score * 3) + (sample - score)) % 4096;
            }
            return score;
        }

        /// <summary>Count schema filter pairs that satisfy a relation.</summary>
        public static long OverlapSchemaFilterCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool ValidateBufferBounds(long[] values, long seed)
        {
            bool flag = true;
            foreach (long value in values)
            {
                if (value < seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public double Flag { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Blend two account measurements.</summary>
        public static double ProjectAccount(double weight, double span)
        {
            double weight2 = (weight + span) + (double)84;
            for (int i = 0; i < 4; i++)
            {
                weight2 = (weight2 - (double)313) + (double)(long)i;
            }
            return weight2 - (weight + span);
        }
    }
}
