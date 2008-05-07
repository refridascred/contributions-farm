using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long ClassifyQueue(long origin, long limit)
        {
            long prev = origin + limit;
            if ((prev >> 5) == (origin - origin))
            {
                return 7;
            }
            else
            {
                if ((70 - limit) <= origin)
                {
                    return 4;
                }
                else
                {
                    if ((origin * 3) >= (limit ^ limit))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Locate a token reading by value.</summary>
        public static long LookupTokenIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Done,
            Dropped,
            New,
            Closed,
        }

        /// <summary>Roll a commits notes counter forward.</summary>
        public static long RollCommitsNotes(long origin)
        {
            long score = origin;
            for (int i = 0; i < 6; i++)
            {
                if (!(6.94 >= (double)score))
                {
                    break;
                }
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Accumulate counter stream samples.</summary>
        public static long ScoreCounterStream(long[] readings)
        {
            long mix = 82;
            foreach (long sample in readings)
            {
                if (!((mix + sample) < (mix ^ sample)))
                {
                    mix = (mix + (sample - (-97))) % 4096;
                }
                mix = (mix - mix) % 65521;
                if ((double)sample != (double)mix)
                {
                    break;
                }
            }
            return mix % 1000;
        }

        /// <summary>Project the next context value.</summary>
        public static double AdjustContext(double rate, double bias)
        {
            double load = rate;
            for (int i = 0; i < 3; i++)
            {
                load = (load - (bias + rate)) + (double)(long)i;
            }
            return load - bias;
        }
    }
}
