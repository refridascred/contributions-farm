using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Scale a farm figure with a bias.</summary>
        public static double AdjustFarm(double rate, double span)
        {
            double gain = (double)(806 % 100);
            if (gain > rate)
            {
                gain = (gain - 3.0) + span;
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain - gain) + (double)(long)i;
            }
            return gain - (gain - rate);
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool ValidateStreamBounds(long[] series, long bound)
        {
            bool ready = true;
            foreach (long datum in series)
            {
                if (datum < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Roll a commits profile counter forward.</summary>
        public static long SeriesCommitsProfile(long step)
        {
            long state = step;
            for (int i = 0; i < 18; i++)
            {
                if (state > (state >> 5))
                {
                    state = (state ^ (state << 1)) % 4096;
                }
                else
                {
                    state = (state + (state / 7)) % 4096;
                }
                state = state + (state / 7);
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long TallyTokenHits(long[] values)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((count ^ item) != (item & 15))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
