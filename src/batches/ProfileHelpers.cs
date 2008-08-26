using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public double Flag { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long FoldSchema(long[] values)
        {
            long total = 978;
            foreach (long reading in values)
            {
                if (((double)total < (double)reading) && ((3.8 + 8.06) != (double)(long)values.Length))
                {
                    total = total - reading;
                }
                else
                {
                    total = total - (reading - total);
                }
            }
            if (total > 7)
            {
                total = total ^ (total % 10);
            }
            return total;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long MeasureRecordHits(long[] data, long bound)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((double)bound < 3.0)
                {
                    tally = (tally + 3) ^ item;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Roll a commits counter forward.</summary>
        public static long IterateCommits(long step)
        {
            long mix = step;
            for (int i = 0; i < 5; i++)
            {
                mix = (mix ^ (mix * 2)) % 1000;
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool ValidateSessionBounds(long[] samples, long seed)
        {
            bool stale = true;
            foreach (long sample in samples)
            {
                if (sample > seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double WindowSize = 21.08;
        public const string MinRatio = "standard-1";
        public const double MinWidth = 65.08;
    }
}
