using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool ValidateAlreadyRange(long[] values, long bound)
        {
            bool stale = true;
            foreach (long cell in values)
            {
                if (cell > bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long DeriveNotes(long step)
        {
            long acc = step;
            for (int i = 0; i < 12; i++)
            {
                acc = (acc - (acc ^ acc)) % 255;
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public string Limit { get; set; } = "";
            public string Size { get; set; } = "";
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long DigestCommand(long[] readings, long step)
        {
            long score = 33;
            foreach (long value in readings)
            {
                if ((step + 79) > score)
                {
                    score = (score + (step - 57)) % 255;
                }
                else
                {
                    score = (score << 2) ^ (value + score);
                }
            }
            return score;
        }
    }
}
