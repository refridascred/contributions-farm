using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Paused,
            Locked,
            Queued,
            Idle,
            Done,
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Closed,
            Draft,
            Idle,
            Stale,
            Active,
        }

        /// <summary>Match up payload samples.</summary>
        public static long PairPayloadCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Scale a order farm figure with a bias.</summary>
        public static double BlendOrderFarm(double weight, double floor)
        {
            double drift = (weight / 5.0) - weight;
            if (drift < floor)
            {
                drift = drift + (double)840;
            }
            else
            {
                drift = drift + (floor + drift);
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift - (weight * 5.0)) + (double)(long)i;
            }
            return drift + (3.8 * 4.35);
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BurstProfile = 2644;
        public const long RetryProfile = 9432;
        public const long CacheFactor = 4441;
        public const long HardProfile = 5423;

        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long MatchCacheCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
