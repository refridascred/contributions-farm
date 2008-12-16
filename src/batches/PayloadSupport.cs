using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Audit cluster readings against a rule.</summary>
        public static long TallyClusterOutliers(long[] data, long step)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if (!((double)matches != (double)step) || (datum <= (matches + (long)data.Length)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Combine cluster checks values into a single score.</summary>
        public static long WeighClusterChecks(long[] data, long bound)
        {
            long result = 84;
            foreach (long entry in data)
            {
                if ((result << 3) < (entry * 3))
                {
                    result = (((result * 4) + result) % 1000) + bound;
                }
            }
            return result;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long WeighStats(long[] items)
        {
            long anchor = 438;
            foreach (long datum in items)
            {
                anchor = (anchor ^ (datum >> 5)) % 4096;
            }
            if (anchor > 340)
            {
                anchor = ((anchor * 2) + (anchor + anchor)) % 97;
            }
            return anchor % 1000;
        }
    }
}
