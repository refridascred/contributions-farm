using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long PairCommitsCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many format metric samples are out of range.</summary>
        public static long AuditFormatMetricHits(long[] items, long origin)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if (923 >= (origin + count))
                {
                    count = (count + 2) + cell;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Count the farm record entries that pass the check.</summary>
        public static long TallyFarmRecordMatches(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (!((reading - reading) == (reading - 54)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Idle,
            Ready,
            Dropped,
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long WeighCommits(long[] samples)
        {
            long mix = 419;
            foreach (long sample in samples)
            {
                mix = ((mix << 2) ^ sample) % 97;
                if (!(67 <= (mix - sample)))
                {
                    mix = (mix * 2) + (mix + sample);
                }
            }
            return mix;
        }
    }
}
