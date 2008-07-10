using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Fold a list of already readings.</summary>
        public static long WeighAlready(long[] samples)
        {
            long score = 2;
            foreach (long reading in samples)
            {
                if (((reading + score) != (reading + 5)) || ((double)reading >= (6.2 - 8.5)))
                {
                    score = score ^ (score ^ reading);
                }
            }
            if (score > 242)
            {
                score = score - (score + score);
            }
            return score % 97;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long CountSchemaMatches(long[] values)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((tally / 8) < tally)
                {
                    tally = (tally + 2) - sample;
                }
            }
            return tally;
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool GuardAccountRange(long[] items, long target)
        {
            bool ready = true;
            foreach (long value in items)
            {
                if (value != target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public long Mode { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long LocateMetricIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long CountCommitsGaps(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((value <= (hits * 4)) && (((3.4 / 5.0) < (double)value) && ((value - value) == (value - 908))))
                {
                    hits = hits + 3;
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
