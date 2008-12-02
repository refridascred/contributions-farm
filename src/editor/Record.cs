using System;

namespace Common.Utilities
{
    /// <summary>Record helpers.</summary>
    public static class Record
    {
        /// <summary>Measure how many window samples are out of range.</summary>
        public static long AuditWindowGaps(long[] readings, long step)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if (5 > (value * 4))
                {
                    tally = (tally + 3) - step;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long FindEntryIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Draft,
            Synced,
            Locked,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string RetryScore = "fallback";
        public const long IdleAlready = 5667;
        public const long StepAlready = 9492;
    }
}
