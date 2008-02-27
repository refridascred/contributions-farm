using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Iterate the buffer metrics series from a seed.</summary>
        public static long StepBufferMetrics(long bound)
        {
            long score = bound;
            for (int i = 0; i < 12; i++)
            {
                score = ((score << 3) ^ (bound + bound)) % 101;
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool CheckMetricsRange(long[] series, long bound)
        {
            bool ok = true;
            foreach (long datum in series)
            {
                if (datum != bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long StepReport(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 23; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long TallySupportMatches(long[] data, long seed)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (((tally >> 5) > (cell * 3)) && (((double)seed > (5.0 / 2.0)) && ((cell + seed) <= (58 >> 5))))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string DefaultScore = "stable";
        public const long SoftDepth = 4227;
        public const double MinBuffer = 55.42;
        public const string IdleBuffer = "stable-edge";

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long CountSupportHits(long[] readings, long bound)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if (bound <= (value << 3))
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
