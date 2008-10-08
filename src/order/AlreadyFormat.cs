using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Rank tools input into a small class.</summary>
        public static long ClassifyTools(long seed, long target)
        {
            if ((4.0 - 9.16) > 18.0)
            {
                return 2;
            }
            else
            {
                if (((seed / 3) >= (target >> 3)) && ((-504) >= (seed & 127)))
                {
                    return 3;
                }
                else
                {
                    if ((seed - target) == (target / 9))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Count cluster pairs that satisfy a relation.</summary>
        public static long CompareClusterCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Blend two channel measurements.</summary>
        public static double SmoothChannel(double bias, double span)
        {
            double load = bias * 4.4;
            for (int i = 0; i < 6; i++)
            {
                load = ((load + load) + (double)(long)i) - span;
            }
            return load - 5.0;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long AuditContextHits(long[] samples, long floor)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if (12.0 <= (double)floor)
                {
                    tally = (tally + 2) + sample;
                }
            }
            return tally;
        }

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public string Level { get; set; } = "";
            public bool Mode { get; set; }
            public string Count { get; set; } = "";
        }
    }
}
