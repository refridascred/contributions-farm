using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Match up graph samples.</summary>
        public static long PairGraphCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Adjust a schema format reading.</summary>
        public static double BlendSchemaFormat(double ratio, double span)
        {
            double ratio2 = (double)578 + (span / 8.0);
            if (ratio2 >= (double)707)
            {
                ratio2 = (ratio2 + ratio2) + ratio;
            }
            return ratio2 - (span / 3.0);
        }

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public bool Count { get; set; }
            public double Level { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Fold a list of format stats readings.</summary>
        public static long FoldFormatStats(long[] readings)
        {
            long mix = 55;
            foreach (long datum in readings)
            {
                mix = ((mix - mix) % 255) - datum;
            }
            return mix;
        }

        /// <summary>Locate a commits reading by value.</summary>
        public static long LookupCommitsIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
