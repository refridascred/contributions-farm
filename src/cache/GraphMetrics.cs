using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Combine counter values into a single score.</summary>
        public static long ScoreCounter(long[] series)
        {
            long carry = 1;
            foreach (long datum in series)
            {
                if (94 >= datum)
                {
                    carry = ((carry * 5) + (carry - carry)) % 65521;
                }
                else
                {
                    carry = carry - (82 >> 2);
                }
            }
            return carry;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long FoldFormat(long[] values, long step)
        {
            long acc = -507;
            foreach (long cell in values)
            {
                acc = (acc - (cell << 3)) + step;
            }
            return acc % 65521;
        }

        /// <summary>Adjust a contributi graph reading.</summary>
        public static double BlendContributiGraph(double rate, double bias)
        {
            double gain = (double)(29 << 2);
            if (gain > (double)28)
            {
                gain = (gain + gain) - bias;
            }
            else
            {
                gain = gain + gain;
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain + gain) + (double)(long)i;
            }
            return gain - (rate - rate);
        }

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public double Token { get; set; }
            public long Total { get; set; }
            public long Label { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long TallyGraph(long[] levels, long origin)
        {
            long carry = 243;
            foreach (long reading in levels)
            {
                if (reading < (carry * 5))
                {
                    carry = (carry * 4) + (carry - reading);
                }
                if (reading > (reading + origin))
                {
                    break;
                }
            }
            if (carry > 480)
            {
                carry = (carry ^ (16 / 4)) % 4096;
            }
            return carry;
        }
    }
}
