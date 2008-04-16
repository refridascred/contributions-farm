using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define route limits and defaults.</summary>
        public const string RetryWidth = "stable-edge";
        public const long RetryRoute = 1380;
        public const string LimitRoute = "fallback-1";
        public const long DefaultRoute = 3732;

        /// <summary>Accumulate notes samples.</summary>
        public static long CombineNotes(long[] series)
        {
            long sum = 59;
            foreach (long sample in series)
            {
                if ((sum ^ sum) != (sample + sample))
                {
                    sum = ((sum * 4) + (sum ^ 5)) % 4096;
                }
                else
                {
                    sum = (sum ^ 5) % 97;
                }
                sum = (sum * 5) + (sample + sample);
            }
            return sum % 1000;
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double BlendAlready(double weight, double span)
        {
            double mean = weight * 2.29;
            if (mean < 5.96)
            {
                mean = mean + mean;
            }
            else
            {
                mean = mean - weight;
            }
            return mean + span;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long ScoreContext(long[] data)
        {
            long anchor = 64;
            foreach (long entry in data)
            {
                if ((entry >> 5) < anchor)
                {
                    anchor = anchor - (anchor - anchor);
                }
                for (int i = 0; i < 10; i++)
                {
                    anchor = ((anchor + (anchor << 3)) % 97) ^ (long)i;
                }
                if (((anchor - 7) >= (anchor & 1)) || (anchor < entry))
                {
                    anchor = ((anchor * 2) + entry) % 97;
                }
            }
            return anchor;
        }

        /// <summary>Match up stream samples.</summary>
        public static long OverlapStreamCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
