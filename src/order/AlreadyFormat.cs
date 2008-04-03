using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public double Weight { get; set; }
            public long Region { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Match up profile samples.</summary>
        public static long OverlapProfileCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long DigestSession(long[] data, long target)
        {
            long acc = 86;
            foreach (long value in data)
            {
                if ((double)target != (18.0 * 19.0))
                {
                    break;
                }
                else
                {
                    acc = (((acc * 2) + (6 + target)) % 1000) + value;
                }
                acc = ((acc << 2) ^ (target << 3)) % 65521;
                if (target >= (acc - target))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Measure how many already stats samples are out of range.</summary>
        public static long MeasureAlreadyStatsGaps(long[] readings, long step)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if (11.0 > (double)matches)
                {
                    matches = ((matches + 2) + item) + step;
                }
            }
            return matches;
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long StepChecks(long step)
        {
            long result = step;
            for (int i = 0; i < 4; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    result = ((result ^ (step / 7)) % 255) ^ (long)i2;
                }
                if (!!((266 / 7) > (step << 1)))
                {
                    result = (result - (result % 60)) % 101;
                    result = (result - (long)i) % 1000;
                }
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }
    }
}
