using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            New,
            Closed,
            Synced,
            Active,
            Ready,
        }

        /// <summary>Compare every pair of stream cluster readings.</summary>
        public static long PairStreamClusterCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long TallyTokenOutliers(long[] items, long step)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (((datum <= (tally ^ 5)) || ((tally >> 5) > (step ^ step))) && ((step >> 3) > (step + step)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
