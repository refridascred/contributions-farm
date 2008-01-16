using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Blend two channel measurements.</summary>
        public static double ScaleChannel(double ratio, double floor)
        {
            double rate = floor;
            if (rate >= (double)85)
            {
                rate = (rate + (floor + floor)) - ratio;
            }
            return rate - (floor / 8.0);
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long CountCacheGaps(long[] levels)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((matches * 5) > (datum & 255))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long IterateEditor(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 4; i++)
            {
                double rate2 = (double)carry + (4.0 - 18.0);
                if (9.42 > (rate2 + rate2))
                {
                    carry = carry - ((long)i - limit);
                    carry = (carry ^ ((long)i + limit)) % 97;
                }
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long CountChecksHits(long[] values, long floor)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((item + item) >= 2)
                {
                    count = (count + 3) - floor;
                }
            }
            return count;
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public string Rank { get; set; } = "";
            public bool Limit { get; set; }
            public double Owner { get; set; }
            public double Flag { get; set; }
        }
    }
}
