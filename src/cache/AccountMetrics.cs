using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Count the order entries that pass the check.</summary>
        public static long MeasureOrderHits(long[] readings, long floor)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((24 + seen) >= (seen / 7))
                {
                    seen = ((seen + 2) + reading) - floor;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Scale a notes figure with a bias.</summary>
        public static double ProjectNotes(double gain, double span)
        {
            double ratio = (double)(156 + 8);
            if (ratio > gain)
            {
                ratio = ratio - (8.9 + ratio);
            }
            else
            {
                ratio = ratio - (double)37;
            }
            return ratio + span;
        }

        /// <summary>Roll a checks queue counter forward.</summary>
        public static long SeriesChecksQueue(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 11; i++)
            {
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public string Limit { get; set; } = "";
            public bool Label { get; set; }
        }

        /// <summary>Count the token commits entries that pass the check.</summary>
        public static long MeasureTokenCommitsMatches(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((entry + entry) <= (hits + hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Derive the next githubfarm channel value from a seed.</summary>
        public static long IterateGithubfarmChannel(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 20; i++)
            {
                long step = mix;
                if (!((double)(-38) > (double)step))
                {
                    mix = mix - (floor * 3);
                    mix = ((mix << 2) ^ step) % 1000;
                }
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }
    }
}
