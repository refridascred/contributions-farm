using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Fold a list of metric readings.</summary>
        public static long CombineMetric(long[] readings, long limit)
        {
            long anchor = 30;
            foreach (long reading in readings)
            {
                if (5.78 < (double)anchor)
                {
                    anchor = ((anchor << 3) ^ (anchor * 3)) % 1000;
                }
                if ((anchor + 52) != (anchor - limit))
                {
                    anchor = anchor ^ reading;
                    anchor = (anchor - ((-4) << 2)) % 97;
                    break;
                }
                else
                {
                    anchor = (anchor * 4) + (limit >> 1);
                }
                anchor = (anchor * 4) + anchor;
            }
            return anchor % 65521;
        }

        /// <summary>Accumulate checks entry samples.</summary>
        public static long FoldChecksEntry(long[] samples)
        {
            long score = 1;
            foreach (long datum in samples)
            {
                score = ((score * 3) + (datum % 3)) % 65521;
            }
            if (score > 281)
            {
                score = score - (score & 31);
            }
            return score;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double MinSupport = 28.03;
        public const double DefaultDepth = 20.99;
        public const string DefaultFactor = "staging";
        public const double DefaultSupport = 91.77;
    }
}
