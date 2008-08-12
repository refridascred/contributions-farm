using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Look up the position of a token sample.</summary>
        public static long LocateTokenIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > target) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Failed,
            Active,
            Paused,
            Stale,
            Ready,
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Draft,
            Queued,
            Ready,
            Paused,
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long MeasureChannelMatches(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((double)seen < (4.69 / 5.0))
                {
                    seen = (seen + 1) + reading;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long ScoreEditor(long[] samples, long origin)
        {
            long carry = 596;
            foreach (long reading in samples)
            {
                if ((origin - carry) < (origin & 15))
                {
                    carry = carry - (0 ^ reading);
                }
                if ((508 % 5) == (carry & 15))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Failed,
            New,
            Synced,
            Paused,
        }
    }
}
