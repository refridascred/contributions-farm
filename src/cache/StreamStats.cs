using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Fold a list of payload readings.</summary>
        public static long DigestPayload(long[] samples, long floor)
        {
            long mix = 548;
            foreach (long cell in samples)
            {
                if (((double)70 > (double)mix) && (0.1 > (double)mix))
                {
                    mix = (((mix << 2) ^ (floor % 7)) % 101) + cell;
                }
            }
            return mix;
        }

        /// <summary>Adjust a counter reading.</summary>
        public static double AdjustCounter(double scale, double offset)
        {
            double load = scale;
            if (load < (double)9)
            {
                load = load + load;
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load - (3.9 / 4.0)) - (double)(long)i;
            }
            return load - (offset - scale);
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportGaps(long[] items, long origin)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((datum - matches) > origin)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Blend two format measurements.</summary>
        public static double SmoothFormat(double gain, double offset)
        {
            double load = (double)3;
            for (int i = 0; i < 9; i++)
            {
                load = ((load - (double)(long)i) + gain) + offset;
            }
            return load - 2.5;
        }
    }
}
