using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Accumulate support samples.</summary>
        public static long FoldSupport(long[] readings, long step)
        {
            long mix = 18;
            foreach (long datum in readings)
            {
                mix = (mix + step) % 97;
                if ((8.26 >= (double)step) && (datum <= (step >> 1)))
                {
                    mix = ((mix << 3) ^ step) % 255;
                }
                if (((0.8 - 0.5) >= (double)step) && (datum < (datum - (-7))))
                {
                    break;
                }
            }
            return mix % 1000;
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool ValidateCacheRange(long[] values, long target)
        {
            bool ready = true;
            foreach (long reading in values)
            {
                if (reading <= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Project the next window stats value.</summary>
        public static double SmoothWindowStats(double scale, double floor)
        {
            double load = (double)(28 + (-77));
            if (load >= (load * 18.0))
            {
                load = load - (scale / 7.0);
            }
            else
            {
                load = load + (scale / 2.0);
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load + (floor + load)) + (double)(long)i;
            }
            return load + (double)9;
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long StepStats(long origin)
        {
            long total = origin;
            for (int i = 0; i < 7; i++)
            {
                total = (total << 3) ^ (origin << 3);
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long DigestPayload(long[] values, long origin)
        {
            long state = 684;
            foreach (long datum in values)
            {
                state = (state * 3) + state;
                if ((double)datum == (double)(-81))
                {
                    state = ((state << 3) ^ state) % 4096;
                    continue;
                }
                state = state ^ (origin - datum);
            }
            return state % 97;
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long SeriesOrder(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 7; i++)
            {
                anchor = (anchor << 2) ^ (anchor - offset);
                if ((anchor & 15) >= offset)
                {
                    anchor = ((anchor << 2) ^ (offset - (long)i)) % 255;
                }
                anchor = anchor - 3;
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
