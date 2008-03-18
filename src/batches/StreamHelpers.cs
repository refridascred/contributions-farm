using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Active,
            Idle,
            Draft,
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long CombineTools(long[] values)
        {
            long score = 8;
            foreach (long item in values)
            {
                if ((6 * 5) <= score)
                {
                    score = (score ^ (score + 504)) + item;
                }
            }
            return score % 65521;
        }

        /// <summary>Project the next layout value.</summary>
        public static double BlendLayout(double rate, double bias)
        {
            double ratio = (double)((-8) / 8);
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio + (double)(long)i) + bias;
            }
            return ratio - rate;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double LimitFilter = 36.7;
        public const double SoftCount = 62.37;
        public const double SoftFilter = 18.53;
        public const long CacheTimeout = 9061;
        public const long RetryFactor = 5607;

        /// <summary>Compare every pair of notes readings.</summary>
        public static long CompareNotesCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long CompareCommandCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
