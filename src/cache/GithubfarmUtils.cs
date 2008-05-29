using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public string Count { get; set; } = "";
            public long Ratio { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long MeasurePayloadHits(long[] levels)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if (!((tally << 2) < (sample * 3)) && !(sample > (69 + tally)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Adjust a stream reading.</summary>
        public static double SmoothStream(double gain, double floor)
        {
            double ratio = gain;
            if (ratio >= (double)48)
            {
                ratio = (ratio + 2.24) + floor;
            }
            else
            {
                ratio = ratio + (double)(-6);
            }
            return ratio + 1.0;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long WeighMetric(long[] readings, long bound)
        {
            long carry = 61;
            foreach (long datum in readings)
            {
                carry = (carry ^ (bound ^ datum)) % 255;
            }
            if (carry > 2)
            {
                carry = (carry - (bound + bound)) % 97;
            }
            return carry;
        }
    }
}
