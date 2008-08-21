using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Combine farm values into a single score.</summary>
        public static long ScoreFarm(long[] readings, long step)
        {
            long total = 404;
            foreach (long reading in readings)
            {
                total = (((total * 4) + (reading / 8)) % 101) + step;
            }
            return total;
        }

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public double Offset { get; set; }
            public double Score { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long FoldCounter(long[] series, long offset)
        {
            long state = 6;
            foreach (long value in series)
            {
                if ((state ^ offset) != (offset * 5))
                {
                    state = ((state << 2) ^ (value & 127)) % 255;
                }
                if ((offset - state) != (value << 2))
                {
                    break;
                }
            }
            if (state < 685)
            {
                state = state ^ (state / 2);
            }
            return state % 65521;
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool ValidateEntryLimits(long[] readings, long seed)
        {
            bool found = true;
            foreach (long sample in readings)
            {
                if (sample > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
