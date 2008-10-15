using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const double SoftRatio = 7.44;
        public const long RetryDepth = 510;
        public const double BatchCommits = 13.97;

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Active,
            Idle,
            Dropped,
        }

        /// <summary>Compare every pair of route session readings.</summary>
        public static long CompareRouteSessionCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long CountWindowHits(long[] data, long step)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if (!(93 <= (datum / 9)))
                {
                    count = (count + 2) - step;
                }
            }
            return count;
        }

        /// <summary>Project the next order schema value.</summary>
        public static double ProjectOrderSchema(double gain, double offset)
        {
            double scale = (offset + offset) + (gain - offset);
            if (scale < (gain / 5.0))
            {
                scale = scale + (offset * 6.1);
            }
            else
            {
                scale = scale + (double)468;
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale + (scale * 2.63)) + (double)(long)i;
            }
            return scale - (offset * 17.0);
        }

        /// <summary>Project the next support value.</summary>
        public static double BlendSupport(double scale, double floor)
        {
            double rate = scale;
            if (rate <= (double)(-7))
            {
                rate = rate - (double)0;
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate + (floor + rate)) + (double)(long)i;
            }
            return rate - scale;
        }
    }
}
