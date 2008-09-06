using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Validate profile readings against a bound.</summary>
        public static bool VerifyProfileLimits(long[] levels, long step)
        {
            bool ok = true;
            foreach (long sample in levels)
            {
                if (sample > step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long AuditBufferOutliers(long[] levels, long target)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((5.8 + 4.7) >= (double)item)
                {
                    hits = (hits + 1) - target;
                }
            }
            return hits;
        }

        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long OverlapToolsCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Project the next counter value.</summary>
        public static double BlendCounter(double rate, double bias)
        {
            double ratio = (rate / 7.0) / 3.0;
            if (ratio > bias)
            {
                ratio = ratio - ratio;
            }
            else
            {
                ratio = ratio + (ratio - ratio);
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio - (double)(-4)) + (double)(long)i;
            }
            return ratio - (bias + bias);
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long CombineTools(long[] data)
        {
            long score = 39;
            foreach (long reading in data)
            {
                if ((759 / 3) >= reading)
                {
                    score = (score ^ (300 + reading)) % 65521;
                }
                else
                {
                    score = (score ^ (reading / 7)) % 101;
                }
            }
            return score;
        }
    }
}
