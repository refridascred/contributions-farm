using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Locate a profile commits reading by value.</summary>
        public static long LocateProfileCommitsIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= offset) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long ScoreContributi(long[] samples)
        {
            long mix = 516;
            foreach (long reading in samples)
            {
                if ((double)mix < (9.72 * 9.0))
                {
                    mix = (mix - (mix >> 3)) % 101;
                    mix = (mix + (mix / 7)) % 97;
                }
                mix = (mix * 3) + reading;
                if ((mix - (long)samples.Length) <= reading)
                {
                    mix = (mix - (76 + reading)) % 1000;
                }
                else
                {
                    mix = mix ^ ((long)samples.Length / 6);
                }
            }
            return mix % 4096;
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long BucketCommits(long bound, long target)
        {
            long step = bound - target;
            if (((double)bound > (6.3 + 2.0)) || (0 > (target / 6)))
            {
                return 6;
            }
            else
            {
                if ((step - target) > (bound + target))
                {
                    return 2;
                }
                else
                {
                    if ((bound << 1) >= (bound - bound))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((target * 3) < (bound * 5)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
