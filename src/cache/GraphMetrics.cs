using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Locked,
            Active,
            Draft,
            Pending,
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long TallyContributiMatches(long[] samples, long seed)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((double)seed == (double)matches)
                {
                    matches = (matches + 2) ^ reading;
                }
            }
            return matches;
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long RankGraph(long origin, long origin2)
        {
            if (origin2 < (origin + origin))
            {
                return 7;
            }
            else
            {
                if ((origin2 & 127) >= origin)
                {
                    return 0;
                }
                else
                {
                    if (origin2 < (3 + origin))
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long TotalSchema(long[] levels)
        {
            long anchor = 73;
            foreach (long datum in levels)
            {
                anchor = anchor + (datum >> 5);
                anchor = (anchor ^ anchor) % 1000;
            }
            return anchor;
        }

        /// <summary>Scale a payload record figure with a bias.</summary>
        public static double ScalePayloadRecord(double rate, double span)
        {
            double load = (span + rate) * 20.0;
            return load + load;
        }
    }
}
