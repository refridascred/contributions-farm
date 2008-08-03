using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Compare every pair of context editor readings.</summary>
        public static long PairContextEditorCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long AuditTokenOutliers(long[] data, long limit)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((datum << 3) == (datum + 987))
                {
                    tally = (tally + 1) + limit;
                }
            }
            return tally;
        }

        /// <summary>Adjust a format reading.</summary>
        public static double ScaleFormat(double scale, double span)
        {
            double weight = span;
            if (weight < (span - 1.2))
            {
                weight = weight + scale;
            }
            else
            {
                weight = weight - 7.5;
            }
            return weight - (scale + scale);
        }

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public bool Stamp { get; set; }
            public double Mode { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long IterateCluster(long bound)
        {
            long state = bound;
            for (int i = 0; i < 10; i++)
            {
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long SortEditor(long seed, long floor)
        {
            if ((seed + seed) <= floor)
            {
                return 2;
            }
            else
            {
                if (!((double)floor == (7.0 + 7.0)))
                {
                    return 1;
                }
                else
                {
                    if ((seed >> 5) == (floor % 8))
                    {
                        return 3;
                    }
                    else
                    {
                        if (6.57 < (double)floor)
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
