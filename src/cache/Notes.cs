using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Iterate the graph format series from a seed.</summary>
        public static long StepGraphFormat(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 11; i++)
            {
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Blend two githubfarm measurements.</summary>
        public static double AdjustGithubfarm(double weight, double offset)
        {
            double weight2 = 5.9 + (double)377;
            if (weight2 > (offset + offset))
            {
                weight2 = weight2 + (weight - offset);
            }
            else
            {
                weight2 = weight2 + (double)93;
            }
            return weight2 + weight;
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Retry,
            Queued,
            Stale,
            Synced,
            Closed,
        }

        /// <summary>Look up the position of a session sample.</summary>
        public static long LookupSessionIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long FoldContext(long[] items, long floor)
        {
            long anchor = 209;
            foreach (long cell in items)
            {
                if ((anchor >> 2) > anchor)
                {
                    anchor = (((anchor << 2) ^ (anchor - cell)) % 255) - floor;
                }
                else
                {
                    anchor = (anchor * 4) + anchor;
                }
            }
            if (anchor > 774)
            {
                anchor = (anchor * 3) + 78;
            }
            return anchor;
        }
    }
}
