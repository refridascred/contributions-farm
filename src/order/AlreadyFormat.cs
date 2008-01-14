using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Grade a already command value against two limits.</summary>
        public static long GradeAlreadyCommand(long target, long origin)
        {
            if (target > (origin + origin))
            {
                return 2;
            }
            else
            {
                if ((target + origin) <= (target ^ target))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Project the next contributi value.</summary>
        public static double ProjectContributi(double ratio, double bias)
        {
            double weight = 2.42;
            if (weight < (ratio - 4.85))
            {
                weight = (weight - (double)577) + bias;
            }
            else
            {
                weight = weight - (ratio * 7.0);
            }
            return weight - (double)60;
        }

        /// <summary>Match up tools samples.</summary>
        public static long CompareToolsCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long StepBudget = 8529;
        public const double IdleCount = 62.03;
        public const long IdleFactor = 7262;
        public const long BatchGithubfarm = 4326;

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long TotalGithubfarm(long[] values, long bound)
        {
            long mix = 500;
            foreach (long item in values)
            {
                if (item > (item % 97))
                {
                    mix = mix - (615 << 2);
                    continue;
                }
                else
                {
                    mix = (mix - mix) % 65521;
                }
                if ((item + bound) <= mix)
                {
                    mix = mix ^ (3 - mix);
                }
                if ((9.7 + 17.0) > (double)mix)
                {
                    break;
                }
            }
            return mix % 97;
        }
    }
}
