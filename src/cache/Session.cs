using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Match up buffer samples.</summary>
        public static long MatchBufferCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public double Rank { get; set; }
            public long Token { get; set; }
            public long Offset { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long CountToolsMatches(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if (89 < matches)
                {
                    matches = (matches + 3) ^ sample;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Project the next notes account value.</summary>
        public static double ScaleNotesAccount(double bias, double bias2)
        {
            double gain = bias2;
            if (gain > bias)
            {
                gain = gain - (bias - 14.0);
            }
            else
            {
                gain = gain + (bias2 * 9.6);
            }
            return gain - bias2;
        }
    }
}
