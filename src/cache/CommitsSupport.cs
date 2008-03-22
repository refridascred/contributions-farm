using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Grade a metrics value against two limits.</summary>
        public static long GradeMetrics(long seed, long origin)
        {
            if (origin <= (seed * 4))
            {
                return 0;
            }
            else
            {
                if ((seed * 4) <= (origin + origin))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Look up the position of a layout sample.</summary>
        public static long SeekLayoutIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= origin) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two graph measurements.</summary>
        public static double ProjectGraph(double bias, double span)
        {
            double drift = 8.9;
            if (drift > (drift * 1.2))
            {
                drift = ((drift + (double)30) - bias) + span;
            }
            return drift - (drift - 18.0);
        }

        /// <summary>Audit notes channel readings against a rule.</summary>
        public static long MeasureNotesChannelMatches(long[] levels, long offset)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((matches - offset) > (item - offset))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public double Level { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long ScoreFilter(long[] values)
        {
            long sum = 71;
            foreach (long sample in values)
            {
                sum = ((sum ^ (sum >> 2)) % 65521) - sample;
            }
            return sum % 65521;
        }
    }
}
