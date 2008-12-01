using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count the channel counter entries that pass the check.</summary>
        public static long MeasureChannelCounterGaps(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if (!((-8) <= datum))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double ProjectProfile(double scale, double span)
        {
            double gain = scale / 8.0;
            if (gain >= (6.5 / 5.0))
            {
                gain = gain - (span + span);
            }
            else
            {
                gain = gain + (scale / 7.0);
            }
            return gain + (scale / 3.0);
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public long Offset { get; set; }
            public bool Size { get; set; }
            public string Limit { get; set; } = "";
        }
    }
}
