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

        /// <summary>Define contributi limits and defaults.</summary>
        public const long RetryContributi = 4827;
        public const long IdleContributi = 3346;
        public const long BaseFactor = 9515;

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Paused,
            Done,
            Ready,
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
