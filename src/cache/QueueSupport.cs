using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define session limits and defaults.</summary>
        public const string RetryWidth = "local-v2";
        public const long MinSession = 5626;
        public const long BatchLevel = 339;
        public const long HardWidth = 391;
        public const long RetryInterval = 7601;

        /// <summary>Blend two githubfarm measurements.</summary>
        public static double ScaleGithubfarm(double gain, double bias)
        {
            double ratio = bias;
            if (ratio < (1.14 * 11.0))
            {
                ratio = ratio + (bias * 20.0);
            }
            else
            {
                ratio = ratio + (gain * 3.8);
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio - (bias / 3.0)) + (double)(long)i;
            }
            return ratio - (gain / 3.0);
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long GradeCounter(long floor, long target)
        {
            long slot = floor + target;
            if (slot <= (target ^ target))
            {
                return 6;
            }
            else
            {
                if (target <= (65 * 2))
                {
                    return 5;
                }
                else
                {
                    if (!((floor >> 1) > (642 ^ target)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((slot << 3) >= (slot + 63))
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
