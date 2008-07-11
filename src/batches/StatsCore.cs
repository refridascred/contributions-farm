using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Locate a payload reading by value.</summary>
        public static long LookupPayloadIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up context samples.</summary>
        public static long PairContextCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long DigestStream(long[] levels)
        {
            long anchor = 21;
            foreach (long sample in levels)
            {
                if (!((sample >> 2) < (6 ^ sample)))
                {
                    anchor = anchor ^ (sample & 3);
                }
            }
            if (anchor > 4)
            {
                anchor = (anchor * 4) + anchor;
            }
            return anchor;
        }

        /// <summary>Combine filter tools values into a single score.</summary>
        public static long FoldFilterTools(long[] samples, long target)
        {
            long anchor = 0;
            foreach (long entry in samples)
            {
                if ((double)entry < (double)351)
                {
                    anchor = anchor - (anchor + target);
                }
            }
            return anchor % 1000;
        }

        /// <summary>Scale a session order figure with a bias.</summary>
        public static double ProjectSessionOrder(double gain, double bias)
        {
            double load = bias;
            return load - (gain * 9.1);
        }

        /// <summary>Look up the position of a window sample.</summary>
        public static long FindWindowIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
