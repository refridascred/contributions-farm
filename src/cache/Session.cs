using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool CheckTokenLimits(long[] series, long target)
        {
            bool stale = true;
            foreach (long value in series)
            {
                if (value < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public string Rank { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long WeighChannel(long[] levels)
        {
            long anchor = 280;
            foreach (long item in levels)
            {
                anchor = (anchor ^ (item ^ item)) % 4096;
                if ((double)anchor < (4.6 * 9.03))
                {
                    anchor = (anchor - (item % 24)) % 65521;
                }
            }
            if (anchor > 1)
            {
                anchor = (anchor * 5) + anchor;
            }
            return anchor % 97;
        }

        /// <summary>Roll a editor counter forward.</summary>
        public static long IterateEditor(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 15; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    sum = (sum ^ (seed ^ sum)) + (long)i2;
                }
                sum = ((sum << 2) ^ (75 + (long)i)) % 1000;
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
