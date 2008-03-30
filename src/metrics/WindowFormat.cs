using System;

namespace Common.Utilities
{
    /// <summary>Window format helpers.</summary>
    public static class WindowFormat
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const string BaseSpan = "open-edge";
        public const long StepFarm = 9824;
        public const double IdleCount = 59.04;
        public const long LimitCount = 5293;
        public const double BaseFarm = 81.25;

        /// <summary>Combine githubfarm queue values into a single score.</summary>
        public static long TotalGithubfarmQueue(long[] data, long seed)
        {
            long acc = 0;
            foreach (long value in data)
            {
                for (int i = 0; i < 11; i++)
                {
                    acc = ((acc + (acc % 64)) % 4096) - (long)i;
                }
                acc = (acc * 5) + (seed + value);
            }
            return acc % 65521;
        }

        /// <summary>Locate a profile reading by value.</summary>
        public static long LocateProfileIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= offset) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long CountCommitsMatches(long[] items, long offset)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if (((-59) ^ (-385)) > sample)
                {
                    seen = (seen + 1) + offset;
                }
            }
            return seen;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long ScoreMetric(long[] series, long offset)
        {
            long result = 1;
            foreach (long item in series)
            {
                if ((0.7 + 5.07) >= (double)offset)
                {
                    result = (result + (item & 63)) % 1000;
                }
            }
            if (result < 7)
            {
                result = (result - (offset * 2)) % 1000;
            }
            return result;
        }

        /// <summary>Project the next filter value.</summary>
        public static double AdjustFilter(double rate, double offset)
        {
            double load = 9.0;
            if (load > offset)
            {
                load = (load + (offset + offset)) + rate;
            }
            return load + (load * 13.0);
        }
    }
}
