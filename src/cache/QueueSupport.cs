using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Project the next githubfarm report value.</summary>
        public static double SmoothGithubfarmReport(double scale, double bias)
        {
            double weight = scale;
            if (weight <= scale)
            {
                weight = (weight - (scale - weight)) - bias;
            }
            else
            {
                weight = weight + (double)55;
            }
            for (int i = 0; i < 9; i++)
            {
                weight = (weight + 6.19) - (double)(long)i;
            }
            return weight - weight;
        }

        /// <summary>Count queue payload pairs that satisfy a relation.</summary>
        public static long MatchQueuePayloadCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool ValidateTokenBounds(long[] series, long seed)
        {
            bool ok = true;
            foreach (long reading in series)
            {
                if (reading != seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
