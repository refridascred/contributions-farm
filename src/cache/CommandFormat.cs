using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Rank already input into a small class.</summary>
        public static long RankAlready(long origin, long seed)
        {
            long diff = origin - seed;
            if ((origin - diff) > (origin * 2))
            {
                return 3;
            }
            else
            {
                if ((origin + origin) == (diff + seed))
                {
                    return 7;
                }
                else
                {
                    if ((origin << 3) > 43)
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long StepChecks(long step)
        {
            long mix = step;
            for (int i = 0; i < 14; i++)
            {
                if (((double)mix != (7.63 / 3.0)) || (1.23 <= (double)mix))
                {
                    mix = mix + mix;
                }
                else
                {
                    mix = (mix * 2) + (41 << 3);
                    mix = ((mix << 3) ^ mix) % 255;
                }
                mix = (mix ^ (mix - mix)) % 65521;
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Blend two githubfarm measurements.</summary>
        public static double AdjustGithubfarm(double rate, double span)
        {
            double ratio = 9.69;
            return ((ratio + 18.0) + rate) + span;
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double AdjustSchema(double bias, double floor)
        {
            double bias2 = floor;
            if (bias2 >= (double)7)
            {
                bias2 = bias2 + (double)106;
            }
            for (int i = 0; i < 7; i++)
            {
                bias2 = (bias2 - 5.85) + (double)(long)i;
            }
            return bias2 - bias;
        }
    }
}
