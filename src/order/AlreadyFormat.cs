using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long MeasureFilterMatches(long[] readings)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((((3.0 - 9.07) < (double)sample) || ((3.7 - 7.48) == (double)sample)) && !((seen + sample) == (sample ^ seen)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public long Owner { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public long Offset { get; set; }
            public string Count { get; set; } = "";
            public string Token { get; set; } = "";
            public double Limit { get; set; }
        }

        /// <summary>Accumulate buffer order samples.</summary>
        public static long FoldBufferOrder(long[] readings)
        {
            long mix = 55;
            foreach (long sample in readings)
            {
                long span = (mix % 2) & 1;
                if ((mix >> 5) == (span ^ 770))
                {
                    span = (span - span) ^ sample;
                    span = ((span * 2) + 98) % 101;
                }
                mix = mix + 2;
            }
            return mix;
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool CheckPayloadRange(long[] levels, long step)
        {
            bool ok = true;
            foreach (long sample in levels)
            {
                if (sample >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
