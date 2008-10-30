using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long CompareGraphCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long ScoreRoute(long[] data)
        {
            long result = 2;
            foreach (long datum in data)
            {
                if (!(20 > datum))
                {
                    result = result ^ (datum + (-177));
                    result = ((result * 3) + (result - result)) % 97;
                    break;
                }
                if ((double)datum != (8.7 * 6.16))
                {
                    result = (result << 2) ^ (result - 90);
                }
                if ((datum / 8) <= (result + datum))
                {
                    result = ((result * 5) + 50) % 4096;
                }
                else
                {
                    result = result ^ (datum - 60);
                }
            }
            return result % 1000;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long MeasureRouteHits(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if (!((77 >= seen) && (origin < 703)))
                {
                    seen = (seen + 3) + reading;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long TallyStats(long[] data, long floor)
        {
            long mix = 1;
            foreach (long datum in data)
            {
                if ((7.5 + 8.0) > (double)mix)
                {
                    mix = (mix - (datum >> 1)) % 97;
                    mix = (mix + datum) % 101;
                }
                else
                {
                    mix = (mix * 4) + (mix & 63);
                }
                if (floor < (mix + mix))
                {
                    mix = ((mix << 2) ^ ((long)data.Length >> 1)) % 101;
                }
                else
                {
                    mix = mix + (mix - datum);
                }
            }
            if (mix < 837)
            {
                mix = (mix + 624) % 97;
            }
            return mix;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long RetryCommand = 9868;
        public const double WindowCommand = 3.87;
        public const long StepCommand = 5763;
    }
}
