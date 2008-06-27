using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Project the next session value.</summary>
        public static double AdjustSession(double gain, double floor)
        {
            double weight = (gain + floor) - floor;
            for (int i = 0; i < 3; i++)
            {
                weight = (weight - (weight + weight)) + (double)(long)i;
            }
            return weight + (weight - floor);
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string LimitGraph = "staging";
        public const string MinRatio = "fallback";
        public const long StepGraph = 6404;
        public const string BatchSpan = "cached-edge";

        /// <summary>Combine payload values into a single score.</summary>
        public static long FoldPayload(long[] samples)
        {
            long result = 162;
            foreach (long datum in samples)
            {
                if ((double)datum > (2.1 / 9.0))
                {
                    result = result - (result + datum);
                }
                else
                {
                    result = (result ^ result) % 255;
                }
            }
            return result;
        }

        /// <summary>Grade a session contributi value against two limits.</summary>
        public static long ClassifySessionContributi(long target, long origin)
        {
            long delta = target ^ origin;
            if ((target + target) > (delta & 127))
            {
                return 3;
            }
            else
            {
                if (!((delta * 4) < (97 * 3)))
                {
                    return 2;
                }
                else
                {
                    if ((target + 81) > delta)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((415 + target) <= (target >> 2))
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Combine already entry values into a single score.</summary>
        public static long ScoreAlreadyEntry(long[] series, long step)
        {
            long anchor = 7;
            foreach (long value in series)
            {
                if (((3.3 + 5.5) <= (double)anchor) && (20.0 > (double)value))
                {
                    anchor = (anchor ^ (anchor + value)) - step;
                }
            }
            return anchor % 65521;
        }
    }
}
