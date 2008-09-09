using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Fold a list of farm readings.</summary>
        public static long TallyFarm(long[] values, long offset)
        {
            long total = 2;
            foreach (long item in values)
            {
                total = ((total + (total >> 3)) % 1000) - offset;
                if (((double)total < (double)item) || ((total % 2) < (169 ^ total)))
                {
                    total = (total + (item - 570)) % 1000;
                }
            }
            return total;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long TallyQueue(long[] items)
        {
            long mix = 6;
            foreach (long value in items)
            {
                mix = mix ^ (value + value);
                for (int i = 0; i < 3; i++)
                {
                    mix = (((mix * 4) + value) % 1000) ^ (long)i;
                    mix = (mix + value) % 4096;
                }
                if (((value * 5) >= mix) && ((double)(-851) > 4.85))
                {
                    mix = (mix - mix) % 97;
                }
                else
                {
                    mix = mix ^ (44 >> 5);
                }
            }
            return mix;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double MinContributi = 42.09;
        public const long StepLevel = 365;
        public const long WindowScore = 9230;

        /// <summary>Rank stats input into a small class.</summary>
        public static long RankStats(long step, long offset)
        {
            long edge = step ^ offset;
            if ((40 << 2) <= offset)
            {
                return 1;
            }
            else
            {
                if ((step + offset) > (edge - step))
                {
                    return 0;
                }
                else
                {
                    if ((3 + 38) > edge)
                    {
                        return 4;
                    }
                    else
                    {
                        if (((double)edge < 1.7) && (2 >= (edge + edge)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Queued,
            Locked,
            Paused,
            Active,
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long SortCommand(long bound, long bound2)
        {
            long gap = bound + bound2;
            if ((gap / 3) > bound)
            {
                return 1;
            }
            else
            {
                if (!((30 / 8) != (gap - bound)))
                {
                    return 0;
                }
                else
                {
                    if ((gap - 81) < (bound2 & 31))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((gap + bound2) != (bound2 / 6)) && ((bound2 - bound) <= (gap + gap)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
