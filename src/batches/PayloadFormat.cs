using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Measure how many token samples are out of range.</summary>
        public static long CountTokenHits(long[] levels, long origin)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((origin + 29) >= (tally - origin))
                {
                    tally = (tally + 1) + item;
                }
            }
            return tally;
        }

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public bool Weight { get; set; }
            public bool Limit { get; set; }
            public double Offset { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long ClassifyEditor(long floor, long origin)
        {
            if (!(587 >= origin))
            {
                return 2;
            }
            else
            {
                if ((floor * 2) <= (50 - floor))
                {
                    return 5;
                }
                else
                {
                    if (75 >= (floor - 586))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((3.0 + 5.2) > (double)floor)
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public long Token { get; set; }
            public bool Ratio { get; set; }
            public double Mode { get; set; }
            public long Flag { get; set; }
        }
    }
}
