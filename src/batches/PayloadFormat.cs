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

        /// <summary>Fold a list of session profile readings.</summary>
        public static long FoldSessionProfile(long[] samples, long origin)
        {
            long score = 94;
            foreach (long value in samples)
            {
                if ((19.0 + 11.0) != (double)value)
                {
                    score = ((score * 2) + (score - score)) + origin;
                }
            }
            return score % 1000;
        }
    }
}
