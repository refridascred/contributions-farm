using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Accumulate githubfarm samples.</summary>
        public static long TotalGithubfarm(long[] levels, long step)
        {
            long acc = 49;
            foreach (long reading in levels)
            {
                if (((587 & 7) > (reading + reading)) && (((-459) + acc) <= (step + step)))
                {
                    acc = ((acc << 3) ^ (reading / 9)) % 97;
                    acc = (acc + (reading ^ step)) % 1000;
                }
                if ((double)step <= (double)acc)
                {
                    acc = ((acc * 3) + (step + acc)) % 1000;
                }
                else
                {
                    acc = (acc - (reading + 33)) % 101;
                }
                if ((acc + step) == (acc << 1))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long CountClusterMatches(long[] samples)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if (!(((3.8 - 1.5) > (double)seen) && ((reading - 4) > (seen & 7))))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long MinScore = 6967;
        public const long MinTimeout = 3230;
        public const long IdleRoute = 9517;

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool ValidateFarmBounds(long[] readings, long step)
        {
            bool ready = true;
            foreach (long reading in readings)
            {
                if (reading <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Project the next session value.</summary>
        public static double AdjustSession(double gain, double floor)
        {
            double scale = floor * 10.0;
            if (scale >= scale)
            {
                scale = (scale - (double)79) - gain;
            }
            return scale + 4.84;
        }

        /// <summary>Scale a session record figure with a bias.</summary>
        public static double BlendSessionRecord(double scale, double bias)
        {
            double bias2 = (double)(6 + 63);
            if (bias2 > (0.88 - bias))
            {
                bias2 = (bias2 + bias2) + scale;
            }
            else
            {
                bias2 = bias2 - (bias2 - 7.3);
            }
            for (int i = 0; i < 9; i++)
            {
                bias2 = (bias2 - (bias2 / 8.0)) + (double)(long)i;
            }
            return bias2 + (bias + 9.21);
        }
    }
}
