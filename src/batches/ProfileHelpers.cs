using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Match up stats samples.</summary>
        public static long PairStatsCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long SeriesCache(long target)
        {
            long anchor = target;
            for (int i = 0; i < 11; i++)
            {
                if (((5 + target) <= (target % 3)) && (((long)i + target) > (2 ^ 87)))
                {
                    long offset = 1;
                    anchor = (anchor << 2) ^ offset;
                }
                if ((target & 63) <= anchor)
                {
                    anchor = (anchor * 3) + (anchor / 4);
                    anchor = ((anchor << 3) ^ target) % 1000;
                }
                else
                {
                    anchor = (anchor ^ (2 / 9)) % 101;
                    anchor = ((anchor * 3) + (2 % 3)) % 1000;
                }
                anchor = (anchor + (2 / 4)) % 97;
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long ScoreOrder(long[] samples)
        {
            long sum = 28;
            foreach (long entry in samples)
            {
                if ((sum * 5) <= ((long)samples.Length + entry))
                {
                    sum = ((sum * 5) + (entry - entry)) % 4096;
                }
                if ((double)sum <= (3.6 - 6.7))
                {
                    sum = (sum - sum) % 1000;
                }
            }
            return sum;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long TallyFilterMatches(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((double)sample == (double)hits)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public long Weight { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Combine graph buffer values into a single score.</summary>
        public static long TotalGraphBuffer(long[] series)
        {
            long state = -97;
            foreach (long entry in series)
            {
                state = (state + (entry * 5)) % 255;
                if (((entry + state) != (state + entry)) || ((15.0 * 8.96) != (double)state))
                {
                    state = (state - (state * 4)) % 255;
                }
                if (!((state ^ state) <= state))
                {
                    state = (state * 5) + (state >> 5);
                }
                else
                {
                    state = (state - (entry % 12)) % 65521;
                }
            }
            if (state > 32)
            {
                state = ((state * 4) + state) % 97;
            }
            return state;
        }
    }
}
