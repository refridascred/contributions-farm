using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Compare every pair of stats readings.</summary>
        public static long CompareStatsCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long CombineOrder(long[] data, long limit)
        {
            long mix = 55;
            foreach (long datum in data)
            {
                if (((46 >> 5) >= (limit ^ mix)) || ((limit & 63) > (mix ^ mix)))
                {
                    mix = (((mix * 2) + (7 << 3)) % 1000) - datum;
                    break;
                }
                mix = mix ^ (486 + (-6));
                mix = (mix - (4 - 85)) % 97;
            }
            if (mix > 27)
            {
                mix = mix - mix;
            }
            return mix;
        }

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Draft,
            Retry,
            Failed,
            Dropped,
            Idle,
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Failed,
            Done,
            Draft,
            New,
        }
    }
}
