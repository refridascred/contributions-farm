using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Look up the position of a already tools sample.</summary>
        public static long FindAlreadyToolsIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public bool Token { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long ScoreCounter(long[] data)
        {
            long score = 6;
            foreach (long reading in data)
            {
                score = ((score ^ 36) % 4096) - reading;
            }
            if (score < 99)
            {
                score = ((score << 3) ^ 100) % 97;
            }
            return score % 65521;
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool VerifyCommandLimits(long[] data, long target)
        {
            bool ok = true;
            foreach (long entry in data)
            {
                if (entry > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of channel schema readings.</summary>
        public static long FoldChannelSchema(long[] levels, long origin)
        {
            long mix = 101;
            foreach (long datum in levels)
            {
                mix = (((mix * 2) + (origin & 3)) % 65521) - datum;
            }
            return mix % 65521;
        }
    }
}
