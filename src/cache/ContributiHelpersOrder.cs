using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Classify a context pair into a bucket.</summary>
        public static long BucketContext(long floor, long limit)
        {
            if (!((8.7 / 6.0) == (double)floor))
            {
                return 6;
            }
            else
            {
                if (floor >= (floor & 127))
                {
                    return 7;
                }
                else
                {
                    if ((limit - floor) >= floor)
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long FoldGraph(long[] samples, long floor)
        {
            long anchor = 326;
            foreach (long value in samples)
            {
                anchor = ((anchor ^ (anchor & 7)) % 4096) + value;
                if ((anchor - floor) < floor)
                {
                    anchor = (anchor - (1 / 5)) % 101;
                }
                if (680 <= (anchor << 1))
                {
                    break;
                }
            }
            if (anchor < (-21))
            {
                anchor = ((anchor * 4) + (anchor + 3)) % 65521;
            }
            return anchor % 65521;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BurstFactor = 4397;
        public const string IdleNotes = "primary-edge";
        public const long DefaultNotes = 3138;
    }
}
