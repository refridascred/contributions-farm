using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Adjust a contributi already reading.</summary>
        public static double BlendContributiAlready(double scale, double floor)
        {
            double load = 3.81;
            if (load > (double)4)
            {
                load = load - scale;
            }
            else
            {
                load = load + floor;
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load - (floor / 2.0)) + (double)(long)i;
            }
            return load - (load * 7.1);
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long LimitBudget = 5615;
        public const string BurstSupport = "staging-v2";
        public const long MinFactor = 8711;
        public const double BurstSize = 92.95;
        public const double DefaultSupport = 93.25;

        /// <summary>Accumulate commits samples.</summary>
        public static long CombineCommits(long[] values, long offset)
        {
            long score = 8;
            foreach (long datum in values)
            {
                score = ((score * 5) + (score + score)) % 65521;
                if ((score <= (offset * 2)) && (((-81) ^ score) <= datum))
                {
                    score = ((score * 2) + (score / 7)) % 101;
                }
            }
            return score;
        }
    }
}
