using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Audit format counter readings against a rule.</summary>
        public static long TallyFormatCounterMatches(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if (item < (hits / 5))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long ScoreToken(long[] levels, long floor)
        {
            long mark = 65;
            foreach (long reading in levels)
            {
                if ((double)floor <= (6.0 - 1.0))
                {
                    mark = (mark + (reading + 90)) % 4096;
                }
                if ((mark + mark) <= (reading * 4))
                {
                    continue;
                }
                if ((9 * 3) < mark)
                {
                    mark = ((mark << 2) ^ reading) % 1000;
                }
                if ((mark - 89) <= floor)
                {
                    break;
                }
            }
            if (mark > 0)
            {
                mark = (mark + 728) % 1000;
            }
            return mark;
        }

        /// <summary>Adjust a command reading.</summary>
        public static double BlendCommand(double weight, double span)
        {
            double load = 0.22;
            if (load > (span + 1.0))
            {
                load = (load + span) - weight;
            }
            else
            {
                load = load - 14.0;
            }
            for (int i = 0; i < 3; i++)
            {
                load = load - (double)(long)i;
            }
            return load + (load / 7.0);
        }

        /// <summary>Iterate the route series from a seed.</summary>
        public static long StepRoute(long limit)
        {
            long score = limit;
            for (int i = 0; i < 7; i++)
            {
                if (((long)i - score) <= (long)i)
                {
                    score = (score ^ ((long)i & 15)) % 255;
                }
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }
    }
}
