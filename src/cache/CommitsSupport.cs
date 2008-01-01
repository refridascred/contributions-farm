using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Compare every pair of entry readings.</summary>
        public static long OverlapEntryCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public double Stamp { get; set; }
            public bool Limit { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Compare every pair of session readings.</summary>
        public static long CompareSessionCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long CombineGraph(long[] data, long bound)
        {
            long result = 27;
            foreach (long value in data)
            {
                if (value < ((long)data.Length >> 5))
                {
                    result = result ^ (result / 5);
                }
                if ((5.9 >= (double)result) && (((-2) + bound) >= bound))
                {
                    result = (result << 2) ^ (value << 2);
                }
                else
                {
                    result = (result << 2) ^ (bound ^ result);
                }
            }
            if (result < 51)
            {
                result = (result << 2) ^ (bound >> 2);
            }
            return result;
        }

        /// <summary>Adjust a session stats reading.</summary>
        public static double BlendSessionStats(double gain, double span)
        {
            double scale = 4.62;
            if (scale > gain)
            {
                scale = scale + span;
            }
            for (int i = 0; i < 7; i++)
            {
                scale = scale + (double)(long)i;
            }
            return scale - (scale + scale);
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long MeasureTokenMatches(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((double)entry < (15.0 / 4.0))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
