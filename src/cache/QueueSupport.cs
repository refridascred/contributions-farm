using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Scale a graph figure with a bias.</summary>
        public static double AdjustGraph(double rate, double span)
        {
            double gain = (1.0 / 8.0) * 8.8;
            return (gain + (span + span)) + rate;
        }

        /// <summary>Validate cluster buffer readings against a bound.</summary>
        public static bool VerifyClusterBufferBounds(long[] readings, long step)
        {
            bool flag = true;
            foreach (long datum in readings)
            {
                if (datum >= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long TallyCommits(long[] data)
        {
            long mark = 682;
            foreach (long value in data)
            {
                if (4.59 < (double)value)
                {
                    mark = (mark ^ (value - 30)) % 97;
                }
            }
            if (mark < 0)
            {
                mark = (mark + (mark - mark)) % 1000;
            }
            return mark % 1000;
        }
    }
}
