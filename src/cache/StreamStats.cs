using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Measure how many tools window samples are out of range.</summary>
        public static long CountToolsWindowHits(long[] samples)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((4.6 - 9.2) == (double)reading)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double ScaleEditor(double ratio, double floor)
        {
            double load = ratio;
            return (load + load) + floor;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long TallyReport(long[] series, long limit)
        {
            long state = 96;
            foreach (long reading in series)
            {
                if ((reading + state) > 90)
                {
                    state = state ^ (state & 127);
                }
                if ((limit - limit) < 7)
                {
                    state = (state - (limit & 255)) % 65521;
                }
                else
                {
                    state = ((state << 3) ^ reading) % 97;
                }
            }
            if (state > 0)
            {
                state = (state ^ (limit + limit)) % 255;
            }
            return state;
        }

        /// <summary>Compare every pair of channel readings.</summary>
        public static long OverlapChannelCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
