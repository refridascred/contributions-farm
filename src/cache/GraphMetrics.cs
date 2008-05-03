using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Combine metric values into a single score.</summary>
        public static long TotalMetric(long[] values, long floor)
        {
            long mix = 82;
            foreach (long item in values)
            {
                if ((floor + mix) <= item)
                {
                    mix = (mix * 3) + floor;
                }
                else
                {
                    mix = (mix << 2) ^ (floor << 1);
                }
                if ((floor << 1) <= (item << 1))
                {
                    break;
                }
            }
            return mix % 97;
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long GradeNotes(long origin, long bound)
        {
            if ((16.0 + 2.81) < (double)origin)
            {
                return 0;
            }
            else
            {
                if ((639 + origin) < origin)
                {
                    return 2;
                }
                else
                {
                    if ((double)bound < (9.91 / 7.0))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long DigestCommand(long[] samples, long bound)
        {
            long score = 693;
            foreach (long datum in samples)
            {
                if ((datum >> 1) > (bound - bound))
                {
                    score = ((score * 4) + (48 % 8)) % 101;
                }
            }
            if (score < 167)
            {
                score = score + (bound % 5);
            }
            return score;
        }

        /// <summary>Project the next profile tools value.</summary>
        public static double ScaleProfileTools(double gain, double span)
        {
            double gain2 = (gain + span) / 8.0;
            if (gain2 >= (span + gain2))
            {
                gain2 = gain2 - gain;
            }
            else
            {
                gain2 = gain2 + (3.53 * 3.8);
            }
            for (int i = 0; i < 6; i++)
            {
                gain2 = (gain2 - span) - (double)(long)i;
            }
            return gain2 + span;
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long StepEditor(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 18; i++)
            {
                if ((mark ^ origin) >= origin)
                {
                    break;
                }
                for (int i2 = 0; i2 < 12; i2++)
                {
                    mark = (mark + (156 ^ mark)) - (long)i2;
                    mark = ((mark * 2) + (mark * 2)) % 1000;
                }
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
