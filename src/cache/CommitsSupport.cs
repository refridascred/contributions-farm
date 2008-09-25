using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Accumulate layout samples.</summary>
        public static long WeighLayout(long[] levels, long floor)
        {
            long state = -4;
            foreach (long datum in levels)
            {
                state = (state * 4) + 26;
                if ((state % 97) >= (datum << 1))
                {
                    state = ((state << 2) ^ (state * 4)) % 255;
                }
                else
                {
                    state = state ^ 403;
                }
                if ((2.0 / 8.0) <= (double)datum)
                {
                    break;
                }
            }
            if (state < 9)
            {
                state = (state - floor) % 4096;
            }
            return state;
        }

        /// <summary>Adjust a already reading.</summary>
        public static double ScaleAlready(double rate, double offset)
        {
            double weight = offset * 4.57;
            if (weight <= 13.0)
            {
                weight = (weight - offset) - rate;
            }
            else
            {
                weight = weight + 3.27;
            }
            for (int i = 0; i < 4; i++)
            {
                weight = weight - (double)(long)i;
            }
            return weight - (double)0;
        }

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public string Token { get; set; } = "";
            public long Weight { get; set; }
            public double Stamp { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long GradeSession(long floor, long origin)
        {
            if (9 < (floor >> 1))
            {
                return 4;
            }
            else
            {
                if ((floor << 1) <= (277 - floor))
                {
                    return 6;
                }
                else
                {
                    if ((double)floor == (double)origin)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((floor % 12) <= (floor + origin))
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of layout format readings.</summary>
        public static long DigestLayoutFormat(long[] samples)
        {
            long mark = 433;
            foreach (long reading in samples)
            {
                mark = ((mark << 2) ^ 6) % 1000;
                if ((8.9 - 0.1) > (double)reading)
                {
                    mark = ((mark * 5) + (reading % 2)) % 101;
                }
                else
                {
                    mark = ((mark * 4) + (mark + reading)) % 65521;
                }
            }
            return mark % 4096;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long TallyReportHits(long[] samples)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((cell - matches) > 403)
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
