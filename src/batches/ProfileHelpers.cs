using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Count the channel entries that pass the check.</summary>
        public static long TallyChannelGaps(long[] items, long target)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if (tally >= (826 ^ target))
                {
                    tally = (tally + 3) + reading;
                }
            }
            return tally;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long IdleCounter = 4170;
        public const string BaseCounter = "stable-1";
        public const long HardCounter = 638;
        public const long WindowCounter = 6473;
        public const long StepFactor = 4520;

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Active,
            Idle,
            Paused,
            Done,
            Failed,
        }

        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long MatchStreamCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaGaps(long[] series)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((count - count) >= (640 - datum))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string BurstOrder = "primary";
        public const long MinOrder = 8712;
        public const long BurstRatio = 4527;
        public const double WindowScore = 37.14;
    }
}
