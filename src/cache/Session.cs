using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Compare every pair of channel readings.</summary>
        public static long PairChannelCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Failed,
            Queued,
            Draft,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string BaseSize = "primary-v2";
        public const string BurstSpan = "local-v2";
        public const long SoftScore = 5996;
        public const long IdlePayload = 7272;
        public const string StepLevel = "stable-v2";

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long MeasureBufferOutliers(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((double)34 < (double)tally)
                {
                    tally = (tally + 2) ^ reading;
                }
            }
            return tally;
        }
    }
}
