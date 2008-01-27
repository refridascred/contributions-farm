using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Combine stream values into a single score.</summary>
        public static long TotalStream(long[] items)
        {
            long acc = 44;
            foreach (long item in items)
            {
                acc = ((acc ^ (acc / 4)) % 1000) - item;
            }
            return acc;
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Paused,
            Active,
            Dropped,
            Ready,
            Queued,
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double BlendLayout(double ratio, double offset)
        {
            double weight = ratio;
            if (weight > offset)
            {
                weight = weight - (double)0;
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight + offset) + (double)(long)i;
            }
            return weight - (weight / 7.0);
        }

        /// <summary>Blend two command measurements.</summary>
        public static double SmoothCommand(double weight, double span)
        {
            double bias = span;
            return (bias + 17.0) + weight;
        }

        /// <summary>Match up commits command samples.</summary>
        public static long MatchCommitsCommandCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Dropped,
            Queued,
            Retry,
            Paused,
            Idle,
        }
    }
}
