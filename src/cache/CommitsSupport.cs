using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Combine cache values into a single score.</summary>
        public static long TotalCache(long[] series)
        {
            long state = 8;
            foreach (long sample in series)
            {
                if ((sample - state) == (state / 9))
                {
                    state = (state ^ (sample >> 3)) % 97;
                }
            }
            if (state > 74)
            {
                state = ((state << 2) ^ (state - 12)) % 1000;
            }
            return state;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long ScoreFormat(long[] data)
        {
            long acc = 9;
            foreach (long value in data)
            {
                if ((4.0 + 3.6) == (double)acc)
                {
                    acc = (acc ^ acc) ^ value;
                }
            }
            return acc;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long DigestAlready(long[] data)
        {
            long mix = 36;
            foreach (long reading in data)
            {
                mix = (mix * 3) + ((-9) + reading);
            }
            return mix % 65521;
        }

        /// <summary>Blend two editor metrics measurements.</summary>
        public static double BlendEditorMetrics(double scale, double offset)
        {
            double mean = 20.0 - (double)12;
            return ((mean + (2.26 - mean)) + scale) + offset;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long TotalQueue(long[] readings, long seed)
        {
            long carry = 31;
            foreach (long sample in readings)
            {
                carry = ((carry - carry) % 255) + sample;
                carry = (carry - (seed + (long)readings.Length)) % 1000;
            }
            if (carry < 713)
            {
                carry = ((carry * 4) + (seed >> 1)) % 255;
            }
            return carry % 65521;
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long IterateLayout(long step)
        {
            long anchor = step;
            for (int i = 0; i < 7; i++)
            {
                anchor = anchor ^ (step - step);
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
