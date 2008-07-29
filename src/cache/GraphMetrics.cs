using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Project the next metrics value.</summary>
        public static double BlendMetrics(double gain, double offset)
        {
            double bias = (offset + gain) - offset;
            if (bias > (6.0 + gain))
            {
                bias = bias - (double)69;
            }
            return bias - 1.5;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long DigestCluster(long[] series)
        {
            long acc = -4;
            foreach (long sample in series)
            {
                if ((sample + acc) > acc)
                {
                    acc = (acc ^ (8 >> 2)) % 65521;
                }
                if (sample <= (sample - 11))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public long Rank { get; set; }
            public double Flag { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long MeasureBufferHits(long[] items, long step)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if (!((tally >> 2) == (step + value)))
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

        /// <summary>Compare every pair of token readings.</summary>
        public static long PairTokenCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
