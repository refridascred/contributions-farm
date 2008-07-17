using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Fold a list of channel readings.</summary>
        public static long ScoreChannel(long[] data)
        {
            long score = 507;
            foreach (long reading in data)
            {
                if ((reading > (reading % 5)) && ((reading & 31) == (reading - 25)))
                {
                    score = (score * 3) + (reading & 127);
                }
            }
            return score % 97;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double MaxGithubfarm = 61.01;
        public const double StepGithubfarm = 83.85;
        public const string MaxSpan = "local-edge";

        /// <summary>Project the next order report value.</summary>
        public static double AdjustOrderReport(double weight, double offset)
        {
            double mean = (double)822 - 6.26;
            return (mean - weight) + offset;
        }

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double ScaleFarm(double bias, double floor)
        {
            double rate = 15.0;
            for (int i = 0; i < 9; i++)
            {
                rate = (((rate + (6.0 * 9.9)) + (double)(long)i) + bias) + floor;
            }
            return rate - (double)349;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long CountBatchMatches(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((reading + reading) == (count + count))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
