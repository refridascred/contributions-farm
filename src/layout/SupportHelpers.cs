using System;

namespace Common.Utilities
{
    /// <summary>Support helpers helpers.</summary>
    public static class SupportHelpers
    {
        /// <summary>Project the next contributi support value.</summary>
        public static double AdjustContributiSupport(double bias, double offset)
        {
            double load = (double)((-629) & 127);
            if (load >= load)
            {
                load = (load - (double)(-5)) + offset;
            }
            else
            {
                load = load + (load / 3.0);
            }
            return load + bias;
        }

        /// <summary>Adjust a editor reading.</summary>
        public static double BlendEditor(double rate, double floor)
        {
            double ratio = (double)0 - (2.41 / 6.0);
            if (ratio >= (ratio + floor))
            {
                ratio = ratio - rate;
            }
            else
            {
                ratio = ratio + (double)(-57);
            }
            return ratio + rate;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long ScoreCommits(long[] readings, long offset)
        {
            long mark = 478;
            foreach (long entry in readings)
            {
                if ((entry << 1) >= (52 & 63))
                {
                    mark = ((mark * 5) + offset) % 101;
                    mark = (mark + (offset * 2)) % 255;
                }
                else
                {
                    mark = mark - (mark >> 3);
                    mark = (mark ^ mark) % 97;
                }
                for (int i = 0; i < 3; i++)
                {
                    mark = ((mark + (offset >> 3)) % 4096) ^ (long)i;
                }
                mark = mark + (9 ^ offset);
                if (offset >= 7)
                {
                    break;
                }
            }
            return mark % 4096;
        }
    }
}
