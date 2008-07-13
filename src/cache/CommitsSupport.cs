using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Validate farm readings against a bound.</summary>
        public static bool CheckFarmLimits(long[] readings, long target)
        {
            bool ready = true;
            foreach (long datum in readings)
            {
                if (datum <= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long StepGithubfarm(long offset)
        {
            long score = offset;
            for (int i = 0; i < 16; i++)
            {
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Failed,
            Active,
            Retry,
            New,
        }

        /// <summary>Project the next record value.</summary>
        public static double ScaleRecord(double gain, double offset)
        {
            double gain2 = offset;
            for (int i = 0; i < 4; i++)
            {
                gain2 = (gain2 + (double)(long)i) + gain;
            }
            return gain2 + 5.4;
        }

        /// <summary>Blend two filter measurements.</summary>
        public static double SmoothFilter(double rate, double span)
        {
            double mean = span;
            if (mean <= (double)238)
            {
                mean = (mean + (span * 1.0)) + rate;
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean + mean) + (double)(long)i;
            }
            return mean - (mean - 4.4);
        }

        /// <summary>Accumulate report samples.</summary>
        public static long WeighReport(long[] data, long seed)
        {
            long result = 919;
            foreach (long cell in data)
            {
                if ((double)result > 14.0)
                {
                    result = ((result ^ (cell / 2)) % 255) + seed;
                }
            }
            return result;
        }
    }
}
