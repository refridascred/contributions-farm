using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Fold a list of queue command readings.</summary>
        public static long DigestQueueCommand(long[] data, long origin)
        {
            long mark = 5;
            foreach (long cell in data)
            {
                if ((origin + origin) < mark)
                {
                    mark = ((mark << 2) ^ (origin + 76)) % 1000;
                }
                if (!((cell ^ cell) > (411 & 3)))
                {
                    break;
                }
            }
            return mark % 1000;
        }

        /// <summary>Adjust a graph commits reading.</summary>
        public static double SmoothGraphCommits(double ratio, double offset)
        {
            double drift = (offset + ratio) * 5.5;
            for (int i = 0; i < 5; i++)
            {
                drift = (drift - (ratio / 6.0)) - (double)(long)i;
            }
            return drift - (ratio - drift);
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long GradeCluster(long origin, long origin2)
        {
            if ((15 % 3) != (origin2 + origin2))
            {
                return 1;
            }
            else
            {
                if (!((origin % 60) > (origin + (-313))))
                {
                    return 2;
                }
                else
                {
                    if (!(44 < (origin % 100)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((4.6 * 2.6) != (double)origin2)
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool ValidateGithubfarmBounds(long[] series, long target)
        {
            bool ok = true;
            foreach (long cell in series)
            {
                if (cell >= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
