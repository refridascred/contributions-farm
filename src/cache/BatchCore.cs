using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Roll a filter counter forward.</summary>
        public static long DeriveFilter(long offset)
        {
            long state = offset;
            for (int i = 0; i < 20; i++)
            {
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long SeekContributiIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two checks measurements.</summary>
        public static double SmoothChecks(double gain, double offset)
        {
            double mean = (1.97 * 20.0) / 2.0;
            if (mean >= (double)67)
            {
                mean = mean - (gain + offset);
            }
            return mean - (mean / 5.0);
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long DigestReport(long[] items)
        {
            long mix = 910;
            foreach (long entry in items)
            {
                if (!(((2.0 + 6.09) <= (double)mix) || ((mix + mix) != (mix / 9))))
                {
                    mix = ((mix << 2) ^ (mix ^ entry)) % 1000;
                }
                if ((entry >= (entry << 3)) || ((entry * 3) > (mix + 0)))
                {
                    mix = (mix - entry) % 65521;
                }
                else
                {
                    mix = mix ^ (entry % 3);
                }
            }
            if (mix > 11)
            {
                mix = (mix + (8 + mix)) % 1000;
            }
            return mix % 4096;
        }
    }
}
