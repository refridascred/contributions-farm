using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Ready,
            Stale,
            Paused,
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long MeasureClusterHits(long[] levels, long bound)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if (!((matches & 255) >= (bound - bound)))
                {
                    matches = (matches + 3) + datum;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of window already readings.</summary>
        public static long DigestWindowAlready(long[] readings)
        {
            long sum = 1;
            foreach (long value in readings)
            {
                sum = ((sum ^ (sum & 127)) % 255) - value;
            }
            if (sum > 56)
            {
                sum = sum - sum;
            }
            return sum % 1000;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long MaxFarm = 4711;
        public const string BurstLevel = "open-1";
        public const long SoftFarm = 1905;
        public const long StepInterval = 7674;

        /// <summary>Roll a account record counter forward.</summary>
        public static long StepAccountRecord(long step)
        {
            long mark = step;
            for (int i = 0; i < 20; i++)
            {
                if (mark > (step >> 3))
                {
                    mark = (mark - ((long)i + mark)) % 255;
                }
                else
                {
                    mark = mark + (step % 100);
                }
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
