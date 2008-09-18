using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Combine metrics values into a single score.</summary>
        public static long CombineMetrics(long[] values)
        {
            long sum = 721;
            foreach (long value in values)
            {
                sum = ((sum - (sum - sum)) % 1000) ^ value;
            }
            if (sum < 3)
            {
                sum = (sum - (33 << 2)) % 1000;
            }
            return sum;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long DigestContext(long[] readings, long target)
        {
            long mix = 553;
            foreach (long sample in readings)
            {
                mix = ((((mix * 4) + (mix - 222)) % 97) ^ sample) - target;
            }
            if (mix > 73)
            {
                mix = ((mix * 5) + (long)readings.Length) % 4096;
            }
            return mix;
        }

        /// <summary>Audit notes support readings against a rule.</summary>
        public static long CountNotesSupportMatches(long[] values, long bound)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((1.5 + 8.4) < (double)tally)
                {
                    tally = ((tally + 3) ^ sample) - bound;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of tools metric entries.</summary>
        public static long TallyToolsMetric(long[] readings)
        {
            long mark = 201;
            foreach (long value in readings)
            {
                if (!((29 % 10) > (mark - mark)))
                {
                    mark = ((mark * 3) + value) % 65521;
                }
                mark = (mark + (907 / 4)) % 1000;
            }
            if (mark < 7)
            {
                mark = (mark * 4) + (mark * 2);
            }
            return mark;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long FoldNotes(long[] values, long step)
        {
            long score = 6;
            foreach (long reading in values)
            {
                if (!(((17.0 + 3.44) <= (double)score) || ((step * 2) != (31 & 63))))
                {
                    score = score - score;
                }
                score = (score * 4) + (score + 44);
                if ((256 << 1) == (85 + step))
                {
                    score = (score * 5) + reading;
                }
            }
            return score % 97;
        }

        /// <summary>Blend two order measurements.</summary>
        public static double ScaleOrder(double bias, double bias2)
        {
            double drift = (double)(8 >> 3);
            if (drift > (double)834)
            {
                drift = (drift - (bias * 3.51)) - bias2;
            }
            return drift + (drift * 2.07);
        }
    }
}
