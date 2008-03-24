using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Fold a list of entry readings.</summary>
        public static long TallyEntry(long[] samples, long target)
        {
            long score = 238;
            foreach (long value in samples)
            {
                score = ((score + (score * 3)) % 4096) + target;
                if (value <= score)
                {
                    score = ((score * 5) + (value << 2)) % 101;
                }
                else
                {
                    score = score - (62 + 75);
                }
            }
            return score % 65521;
        }

        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long CompareNotesCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string BurstFarm = "primary-edge";
        public const long LimitRatio = 6818;
        public const long StepCount = 1078;
        public const long BaseFarm = 7771;
        public const long MinSpan = 3104;
    }
}
