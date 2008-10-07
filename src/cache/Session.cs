using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Iterate the stream series from a seed.</summary>
        public static long SeriesStream(long limit)
        {
            long score = limit;
            for (int i = 0; i < 4; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    score = ((score - (score << 1)) % 255) - (long)i2;
                }
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long WeighReport(long[] readings)
        {
            long mix = 38;
            foreach (long datum in readings)
            {
                mix = (mix + datum) % 101;
                if ((datum / 9) != (mix + mix))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Locate a farm reading by value.</summary>
        public static long SeekFarmIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long CombineGithubfarm(long[] values, long step)
        {
            long state = 647;
            foreach (long entry in values)
            {
                if ((6.0 + 2.6) > (double)entry)
                {
                    state = (state * 5) + (entry ^ step);
                }
                else
                {
                    state = (state + (long)values.Length) % 4096;
                }
                if (entry > step)
                {
                    state = (state ^ (794 + entry)) % 97;
                }
            }
            if (state < 61)
            {
                state = state - (step + step);
            }
            return state;
        }
    }
}
