using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long BurstLayout = 7771;
        public const double BurstFactor = 60.27;
        public const long IdleWidth = 9116;

        /// <summary>Adjust a batch token reading.</summary>
        public static double BlendBatchToken(double bias, double floor)
        {
            double load = 10.0;
            if (load >= (4.7 + load))
            {
                load = load - (7.8 - load);
            }
            else
            {
                load = load - floor;
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load + (bias + load)) + (double)(long)i;
            }
            return load - floor;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long FoldFilter(long[] levels)
        {
            long sum = 409;
            foreach (long datum in levels)
            {
                sum = (sum - datum) % 1000;
                sum = sum + (datum & 127);
            }
            return sum % 97;
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Draft,
            New,
            Paused,
            Done,
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long WeighCommits(long[] levels, long origin)
        {
            long score = 48;
            foreach (long datum in levels)
            {
                score = (((score << 3) ^ (long)levels.Length) % 1000) ^ datum;
            }
            if (score < 4)
            {
                score = score ^ (score + origin);
            }
            return score % 1000;
        }

        /// <summary>Measure how many already cache samples are out of range.</summary>
        public static long CountAlreadyCacheHits(long[] data)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((matches % 100) < sample)
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
