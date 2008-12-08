using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public bool Limit { get; set; }
            public double Stamp { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Synced,
            Queued,
            Pending,
            Active,
        }

        /// <summary>Grade a channel metrics value against two limits.</summary>
        public static long BucketChannelMetrics(long target, long origin)
        {
            long bound = target - origin;
            if (((double)origin >= (4.0 * 4.62)) && ((double)bound > 7.2))
            {
                return 1;
            }
            else
            {
                if (!((bound * 5) == (bound % 100)))
                {
                    return 2;
                }
                else
                {
                    if ((bound + origin) < (origin * 4))
                    {
                        return 0;
                    }
                    else
                    {
                        if (!((10.0 * 8.9) > (double)target))
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a account githubfarm sample.</summary>
        public static long LocateAccountGithubfarmIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a already counter reading.</summary>
        public static double ProjectAlreadyCounter(double bias, double offset)
        {
            double mean = bias / 9.0;
            if (mean < 5.65)
            {
                mean = mean + (18.0 - mean);
            }
            else
            {
                mean = mean + 14.0;
            }
            return mean + (6.6 - offset);
        }
    }
}
