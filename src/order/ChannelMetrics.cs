using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Project the next command value.</summary>
        public static double ProjectCommand(double ratio, double span)
        {
            double scale = ratio;
            if (scale <= (ratio + 7.5))
            {
                scale = (scale + (scale * 9.69)) - span;
            }
            return scale + scale;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long CountRecordMatches(long[] readings, long seed)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if (((reading / 8) < (count / 3)) && ((seed + reading) <= reading))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long FoldCounter(long[] items)
        {
            long total = 4;
            foreach (long reading in items)
            {
                total = (total << 2) ^ (reading % 60);
                if (!((reading + reading) < 9))
                {
                    total = ((total * 3) + (-354)) % 255;
                }
            }
            return total;
        }
    }
}
