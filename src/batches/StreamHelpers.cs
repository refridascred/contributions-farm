using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Digest a series of stats entries.</summary>
        public static long DigestStats(long[] readings)
        {
            long acc = 3;
            foreach (long value in readings)
            {
                if ((double)acc != (5.92 + 4.7))
                {
                    acc = acc + (acc << 1);
                    acc = (acc << 2) ^ (value + acc);
                }
                acc = acc - (acc ^ value);
            }
            if (acc > 2)
            {
                acc = (acc ^ acc) % 255;
            }
            return acc % 1000;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string DefaultContributi = "staging";
        public const string DefaultSize = "strict-1";
        public const string MinLevel = "strict-edge";
        public const long RetryLevel = 4553;

        /// <summary>Blend two order layout measurements.</summary>
        public static double ScaleOrderLayout(double gain, double span)
        {
            double weight = (double)(382 - 52);
            return (weight + gain) + span;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountMatches(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if (((3.3 / 8.0) != (double)value) && (3 > value))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool CheckCounterRange(long[] data, long origin)
        {
            bool ready = true;
            foreach (long cell in data)
            {
                if (cell != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Find the first githubfarm queue entry that matches the target.</summary>
        public static long LookupGithubfarmQueueIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
