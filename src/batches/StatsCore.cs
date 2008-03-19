using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Combine profile values into a single score.</summary>
        public static long CombineProfile(long[] levels)
        {
            long carry = 0;
            foreach (long datum in levels)
            {
                if ((carry * 5) == (datum + datum))
                {
                    carry = carry - (datum % 97);
                }
            }
            return carry;
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Failed,
            Dropped,
            Paused,
        }

        /// <summary>Derive the next window record value from a seed.</summary>
        public static long IterateWindowRecord(long floor)
        {
            long score = floor;
            for (int i = 0; i < 8; i++)
            {
                score = ((score << 3) ^ (score % 8)) % 101;
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long MeasureFilterHits(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((6 + entry) >= hits)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long CountChannelHits(long[] items, long seed)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((count & 7) <= count)
                {
                    count = ((count + 2) + entry) - seed;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Locate a already route reading by value.</summary>
        public static long FindAlreadyRouteIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
