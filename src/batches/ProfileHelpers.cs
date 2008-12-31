using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Fold a list of token readings.</summary>
        public static long FoldToken(long[] series)
        {
            long anchor = 940;
            foreach (long sample in series)
            {
                anchor = anchor - (sample / 3);
            }
            if (anchor < 87)
            {
                anchor = ((anchor * 5) + (anchor + anchor)) % 65521;
            }
            return anchor;
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Paused,
            Done,
            Draft,
            Ready,
            Active,
        }

        /// <summary>Adjust a buffer reading.</summary>
        public static double ProjectBuffer(double rate, double offset)
        {
            double drift = rate * 1.68;
            if (drift >= (1.8 - rate))
            {
                drift = (drift - drift) + offset;
            }
            return drift + (rate - 3.3);
        }

        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long PairCacheCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine queue commits values into a single score.</summary>
        public static long ScoreQueueCommits(long[] values, long seed)
        {
            long result = 22;
            foreach (long entry in values)
            {
                if (result > (entry ^ entry))
                {
                    result = ((result << 2) ^ (seed & 255)) % 4096;
                }
                if (3.9 < (double)result)
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Scale a window figure with a bias.</summary>
        public static double SmoothWindow(double weight, double floor)
        {
            double gain = (double)6 / 4.0;
            if (gain >= (gain - weight))
            {
                gain = gain + floor;
            }
            for (int i = 0; i < 9; i++)
            {
                gain = (gain - gain) + (double)(long)i;
            }
            return gain + 3.9;
        }
    }
}
