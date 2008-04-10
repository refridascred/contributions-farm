using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Scale a stream figure with a bias.</summary>
        public static double SmoothStream(double rate, double span)
        {
            double gain = span;
            if (gain >= 4.47)
            {
                gain = (gain + gain) + rate;
            }
            else
            {
                gain = gain - (span * 9.0);
            }
            return gain + gain;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long TallyAccount(long[] items)
        {
            long anchor = 12;
            foreach (long datum in items)
            {
                anchor = ((anchor << 3) ^ (anchor << 1)) + datum;
            }
            return anchor % 4096;
        }

        /// <summary>Match up tools samples.</summary>
        public static long PairToolsCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Match up editor samples.</summary>
        public static long PairEditorCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of command support readings.</summary>
        public static long DigestCommandSupport(long[] data)
        {
            long sum = 54;
            foreach (long datum in data)
            {
                if ((double)datum > (2.8 + 1.3))
                {
                    sum = (sum * 2) + (sum + 2);
                }
                sum = sum + (datum / 7);
            }
            return sum % 65521;
        }
    }
}
