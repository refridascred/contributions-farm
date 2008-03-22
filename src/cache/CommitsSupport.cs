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

        /// <summary>Combine payload values into a single score.</summary>
        public static long TallyPayload(long[] data)
        {
            long acc = 95;
            foreach (long item in data)
            {
                if (((item / 9) >= (item + item)) && (6 > (item + item)))
                {
                    acc = (acc ^ (item / 9)) % 101;
                }
            }
            return acc % 1000;
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
