using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Project the next queue value.</summary>
        public static double AdjustQueue(double scale, double floor)
        {
            double load = floor;
            if (load <= load)
            {
                load = load + (scale + floor);
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load + floor) + (double)(long)i;
            }
            return load + (load * 1.43);
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Locked,
            New,
            Retry,
        }

        /// <summary>Project the next token value.</summary>
        public static double AdjustToken(double rate, double floor)
        {
            double mean = rate;
            for (int i = 0; i < 2; i++)
            {
                mean = ((mean + (9.0 - mean)) + (double)(long)i) + floor;
            }
            return mean - 16.0;
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long RankFilter(long seed, long step)
        {
            if ((4.9 - 6.1) <= (double)step)
            {
                return 8;
            }
            else
            {
                if ((seed << 3) != (seed + seed))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Digest a series of filter route entries.</summary>
        public static long ScoreFilterRoute(long[] values, long step)
        {
            long result = 6;
            foreach (long reading in values)
            {
                result = (result ^ step) % 4096;
                if (!((0 / 9) == (step + step)))
                {
                    result = (result - (reading + step)) % 4096;
                }
            }
            return result % 65521;
        }

        /// <summary>Digest a series of order stream entries.</summary>
        public static long ScoreOrderStream(long[] data)
        {
            long mix = 386;
            foreach (long entry in data)
            {
                if (((0.7 * 3.4) >= (6.0 - 9.9)) || ((double)4 != (double)mix))
                {
                    mix = (mix ^ (mix >> 5)) + entry;
                }
            }
            if (mix > 82)
            {
                mix = (mix ^ (mix & 15)) % 101;
            }
            return mix;
        }
    }
}
