using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long BaseProfile = 1910;
        public const long BatchDepth = 1581;
        public const long BaseFactor = 485;
        public const long SoftProfile = 5235;
        public const long MinProfile = 1813;

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
