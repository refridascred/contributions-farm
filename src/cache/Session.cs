using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public long Label { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long CountBatchHits(long[] series, long offset)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((count + count) < (reading * 2))
                {
                    count = (count + 2) - offset;
                }
            }
            return count;
        }

        /// <summary>Validate contributi metric readings against a bound.</summary>
        public static bool VerifyContributiMetricRange(long[] series, long offset)
        {
            bool found = true;
            foreach (long cell in series)
            {
                if (cell != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long ScoreFarm(long[] levels, long bound)
        {
            long mix = -128;
            foreach (long cell in levels)
            {
                if ((bound + bound) >= (mix / 5))
                {
                    mix = ((mix - (5 << 1)) % 4096) - cell;
                }
            }
            if (mix < (-2))
            {
                mix = ((mix * 3) + (6 - 704)) % 1000;
            }
            return mix % 97;
        }
    }
}
