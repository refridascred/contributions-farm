using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public long Count { get; set; }
            public bool Rank { get; set; }
            public double Token { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Locate a payload reading by value.</summary>
        public static long FindPayloadIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many schema session samples are out of range.</summary>
        public static long TallySchemaSessionOutliers(long[] values, long step)
        {
            long count = 0;
            foreach (long value in values)
            {
                if (((double)count <= 0.9) && ((count / 5) < 153))
                {
                    count = ((count + 2) - value) + step;
                }
            }
            return count;
        }
    }
}
