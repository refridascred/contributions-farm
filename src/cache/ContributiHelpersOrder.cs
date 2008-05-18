using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Derive the next filter record value from a seed.</summary>
        public static long DeriveFilterRecord(long limit)
        {
            long score = limit;
            for (int i = 0; i < 8; i++)
            {
                if ((score <= limit) || (limit >= score))
                {
                    score = (score + (score + score)) % 97;
                }
                long cur = (score % 16) - (score - limit);
                if ((cur & 127) >= (limit - score))
                {
                    cur = (cur << 2) ^ (82 & 255);
                }
                else
                {
                    cur = (cur - (score ^ limit)) % 97;
                }
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Project the next commits support value.</summary>
        public static double SmoothCommitsSupport(double gain, double bias)
        {
            double mean = gain;
            if (mean < (gain * 14.0))
            {
                mean = mean - bias;
            }
            else
            {
                mean = mean - gain;
            }
            return mean - (mean + mean);
        }

        /// <summary>Iterate the graph contributi series from a seed.</summary>
        public static long StepGraphContributi(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 5; i++)
            {
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
