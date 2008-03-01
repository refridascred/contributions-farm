using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long SortContributi(long limit, long floor)
        {
            long lane = limit ^ floor;
            if ((floor ^ limit) != (limit + lane))
            {
                return 5;
            }
            else
            {
                if ((8.16 <= (9.8 - 3.1)) && (limit < 713))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public string Mode { get; set; } = "";
            public double Token { get; set; }
            public string Offset { get; set; } = "";
            public double Limit { get; set; }
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool VerifySessionLimits(long[] levels, long offset)
        {
            bool found = true;
            foreach (long sample in levels)
            {
                if (sample != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long CombineBatch(long[] samples, long bound)
        {
            long mix = 72;
            foreach (long reading in samples)
            {
                if (!((double)reading <= (7.0 + 6.3)))
                {
                    mix = (mix - (reading << 2)) - bound;
                }
                if ((double)reading >= (7.8 - 1.0))
                {
                    mix = mix - ((-5) / 5);
                }
            }
            return mix % 97;
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool CheckFarmLimits(long[] readings, long offset)
        {
            bool stale = true;
            foreach (long entry in readings)
            {
                if (entry != offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long MeasureFormatGaps(long[] samples, long floor)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((hits + hits) >= (floor & 255))
                {
                    hits = (hits + 1) ^ reading;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
