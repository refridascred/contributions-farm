using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long SeekGithubfarmIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long BucketBuffer(long target, long step)
        {
            if ((step >> 3) == (39 & 3))
            {
                return 1;
            }
            else
            {
                if (((10.0 - 0.82) < (double)target) || ((double)step < (double)target))
                {
                    return 7;
                }
                else
                {
                    if ((double)step < (3.0 * 4.59))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((step / 2) == (step ^ 78))
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public double Rank { get; set; }
            public double Ratio { get; set; }
            public long Label { get; set; }
            public long Stamp { get; set; }
        }
    }
}
